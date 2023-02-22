﻿using FuelStation.Web.Shared.UserSession;
using Microsoft.Identity.Client;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace FuelStation.Web.Server.Authentication {
	public class JwtAuthenticationManager {

		public const string JWT_SECURITY_KEY = "ufCrVARDHmHBbaBfCiZstCtBUgNqrTcMMNjWNFBqMqQ";
		private const int JWT_TOKEN_VALIDITY_MINS = 30;

		private UserAccountService _userAccountService;

		public JwtAuthenticationManager(UserAccountService userAccountService) {
			_userAccountService = userAccountService;
		}
		public UserSession? GenerateJwtToken(string userName, string password) {
			if (string.IsNullOrWhiteSpace(userName) || string.IsNullOrWhiteSpace(password))
				return null;

			/* Validating the User Credentials */
			var userAccount = _userAccountService.GetUserAccountByUserName(userName);
			if (userAccount == null || userAccount.Password != password)
				return null;

			/* Generating JWT Token*/
			var tokenExpiryTimeStamp = DateTime.Now.AddMinutes(JWT_TOKEN_VALIDITY_MINS);
			var tokenKey = Encoding.ASCII.GetBytes(JWT_SECURITY_KEY);
			var claimsIdentity = new ClaimsIdentity(new List<Claim> {
				new Claim(ClaimTypes.Name, userAccount.UserName),
				new Claim(ClaimTypes.Role, userAccount.Role)
			});
			var signingCredentials = new SigningCredentials(
				new SymmetricSecurityKey(tokenKey),
				SecurityAlgorithms.HmacSha256Signature);
			var securityTokenDesriptor = new SecurityTokenDescriptor {
				Subject = claimsIdentity,
				Expires = tokenExpiryTimeStamp,
				SigningCredentials = signingCredentials
			};

			var jwtSecurityTokenHandler = new JwtSecurityTokenHandler();
			var securityToken = jwtSecurityTokenHandler.CreateToken(securityTokenDesriptor);
			var token = jwtSecurityTokenHandler.WriteToken(securityToken);

			/* Returning the User Session object*/
			var userSession = new UserSession {
				UserName = userAccount.UserName,
				Role = userAccount.Role,
				Token = token,
				ExpiresIn = (int)tokenExpiryTimeStamp.Subtract(DateTime.Now).TotalSeconds
			};
			return userSession;
		}	
	}
}

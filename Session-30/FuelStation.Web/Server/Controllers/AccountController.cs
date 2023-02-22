using FuelStation.Web.Server.Authentication;
using FuelStation.Web.Shared.UserSession;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FuelStation.Web.Server.Controllers {
	[Route("[controller]")]
	[ApiController]
	public class AccountController : ControllerBase {

		private UserAccountService _userAccountService;
		
		public AccountController(UserAccountService userAccountService) {
			_userAccountService = userAccountService;
		}

		[HttpPost]
		[Route("Login")]
		[AllowAnonymous]
		public ActionResult<UserSession> Login([FromBody] LoginRequest loginRequest) {
			var jwtAuthenticationManager = new JwtAuthenticationManager(_userAccountService);
			var userSession = jwtAuthenticationManager.GenerateJwtToken(loginRequest.UserName, loginRequest.Password);
			if (userSession is null) {
				return Unauthorized();
			} else {
				return userSession;
			}
		}
	}
}

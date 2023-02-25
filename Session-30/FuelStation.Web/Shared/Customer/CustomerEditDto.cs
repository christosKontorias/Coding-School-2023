﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.Web.Shared.Customer {
	public class CustomerEditDto {
		public int Id { get; set; }
		[Required]
		[MaxLength(50, ErrorMessage = "Name must have max length 50 letters.")]
		public string Name { get; set; } = null!;
		[Required]
		[MaxLength(50, ErrorMessage = "Surname must have max length 50 letters.")]
		public string Surname { get; set; } = null!;
		[Required]
		[MaxLength(20, ErrorMessage = "Card Number must have max length 20 characters.")]
        [RegularExpression("^A.*", ErrorMessage = "Card Number must start with the letter 'A'")]
        public string CardNumber { get; set; } = null!;
	}
}

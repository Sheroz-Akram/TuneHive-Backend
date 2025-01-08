﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuneHive.Application.Services.Account.Dto
{
    public class RegistrationRequestDto
    {
        [Required]
        public string FirstName { get; set; }  = string.Empty;
        [Required]
        public string LastName { get; set; } = string.Empty;
        [Required]
        public DateOnly BirthDate { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;
        [Required]
        [MinLength(8)]
        public string Password { get; set; } = string.Empty;
    }
}

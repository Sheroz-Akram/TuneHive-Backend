﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuneHive.Application.Services.Account.Dto
{
    public class ForgotPasswordRequestDto
    {
        [Required]
        public string Email { get; set; } = string.Empty;
    }
}

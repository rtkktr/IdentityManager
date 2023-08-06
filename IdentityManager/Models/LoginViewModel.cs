﻿using System.ComponentModel.DataAnnotations;

namespace IdentityManager.Models
{
    public class LoginViewModel
    {
        [EmailAddress]
        public string? Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string? Password { get; set; }

        [Display(Name = "Remember me?")]
        public bool RememberMe { get; set;}
    }
}

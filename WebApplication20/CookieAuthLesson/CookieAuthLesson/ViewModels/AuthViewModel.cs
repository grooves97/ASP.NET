﻿using System.ComponentModel.DataAnnotations;

namespace CookieAuthLesson.ViewModels
{
    public class AuthViewModel
    {
        [EmailAddress(ErrorMessage = "Введен не корректный email")]
        [Required]
        public string Email { get; set; }
        [MinLength(6)]
        [Required]
        public string Password { get; set; }
    }
}

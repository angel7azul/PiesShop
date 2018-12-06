using System;
using PiesShop.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PiesShop.ViewModels
{
    public class LoginViewModel
    {
        [Required]
        [Display(Name = "User Name")]
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CCBS1.Models.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "{0} is ee nverplicht veld.")]
        [EmailAddress(ErrorMessage = "Dit is geen geldige e-mailadres")]
        [Display(Name = "E-mail")]
        public string Email { get; set; }

        [Required(ErrorMessage = "{0} is ee nverplicht veld.")]
        [DataType(DataType.Password)]
        [Display(Name = "Wachtwoord")]
        public string Password { get; set; }

        [Display(Name = "Onthoud mij")]
        public bool RememberMe { get; set; }
    }
}

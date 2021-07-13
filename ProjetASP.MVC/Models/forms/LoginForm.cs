using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetASP.MVC.Models.forms
{
    public class LoginForm
    {
        [Required]
        [EmailAddress]
        [DisplayName("Email : ")]
        public string AdresseMail { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [StringLength(20, MinimumLength = 8)]
        [DisplayName("Mot de passe : ")]
        public string MotDePasse { get; set; }
    }
}
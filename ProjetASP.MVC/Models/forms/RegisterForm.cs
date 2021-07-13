using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetASP.MVC.Models.forms
{
        public class RegisterForm
        {
            [Required]
            [StringLength(50, MinimumLength = 1)]
            [DisplayName("Nom : ")]
            public string Nom { get; set; }
            [Required]
            [StringLength(50, MinimumLength = 2)]
            [DisplayName("Prénom : ")]
            public string Prenom { get; set; }
            [Required]
            [EmailAddress]
            [DisplayName("Email : ")]
            public string AdresseMail { get; set; }
            [Required]
            [DataType(DataType.Password)]
            [StringLength(20, MinimumLength = 8)]
            [DisplayName("Mot de passe : ")]
            public string MotDePasse { get; set; }
            [Required]
            public string Telephone { get; set; }
            [Required]
            public string Roles { get; set; }
            [Required]
        
            public int CP { get; set; }
            public int Num { get; set; }
            public string Rue { get; set; }
            public string Pays { get; set; }
            public double CGLatitude { get; set; }
            public double CGLongitude { get; set; }

            public string Ville { get; set; }

    }   
}

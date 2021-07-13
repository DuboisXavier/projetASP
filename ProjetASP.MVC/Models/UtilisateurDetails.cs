using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetASP.MVC.Models
{
    [Flags]
    public enum RoleUser
    {
        Simple = 1,
        Admin = 2
    }
    public class UtilisateurDetails
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string AdresseMail { get; set; }
        public string Telephone { get; set; }
        public string MotDePasse { get; set; }
        public string Roles { get; set; }
        public RoleUser Role { get; set; }
        public int CP { get; set; }
        public int Num { get; set; }
        public string Rue { get; set; }
        public string Pays { get; set; }
        public double CGLatitude { get; set; }
        public double CGLongitude { get; set; }

        public string Ville { get; set; }


    }
}
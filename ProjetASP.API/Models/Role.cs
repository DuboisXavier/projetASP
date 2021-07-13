using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetASP.API.Models
{
    public class Role
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public Role(Projet.DALClient.Models.Role role)
        {
            Id = role.Id;
            Nom = role.Nom;
            
        }
        public Role()
        {
        }
    }
}
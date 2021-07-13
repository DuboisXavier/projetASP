using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using G = Projet.DALGlobal.Models;

namespace Projet.DALClient.Models
{
    public class Role
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public Role()
        {

        }

        public Role(G.Role entity)
        {
            Id = entity.Id;
            Nom = entity.Nom;
        }
    }
    
}

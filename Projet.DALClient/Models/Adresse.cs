using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using G = Projet.DALGlobal.Models;

namespace Projet.DALClient.Models
{
    public class Adresse
    {
        public int Id { get; set; }
        public int CP { get; set; }
        public int Num { get; set; }
        public string Rue { get; set; }
        public string Pays { get; set; }
        public double CGLatitude { get; set; }
        public double CGLongitude { get; set; }
        public string Ville { get; set; }

        public Adresse(G.Adresse entity)
        {
            Id = entity.Id;
            CP = entity.CP;
            Num = entity.Num;
            Rue = entity.Rue;
            Pays = entity.Pays;
            CGLatitude = entity.CGLatitude;
            CGLongitude = entity.CGLongitude;
            Ville = entity.Ville;

        }
        public Adresse()
        {

        }
    }
    
}

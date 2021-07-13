using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetASP.API.Models
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

        public Adresse(Projet.DALClient.Models.Adresse adresse)
        {
            Id = adresse.Id;
            CP = adresse.CP;
            Num = adresse.Num;
            Rue = adresse.Rue;
            Pays = adresse.Pays;
            CGLatitude = adresse.CGLatitude;
            CGLongitude = adresse.CGLongitude;
            Ville = adresse.Ville;
 
        }
        public Adresse()
        {

        }
    }
}
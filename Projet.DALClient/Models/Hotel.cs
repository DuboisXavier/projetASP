using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using G = Projet.DALGlobal.Models;

namespace Projet.DALClient.Models
{
    public class Hotel
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public int NombreEtoile { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }
        public int NombreChambre { get; set; }
        public string Ville { get; set; }
        public string Pays { get; set; }
        public int AdresseId { get; set; }
        public int CP { get; set; }
        public int Num { get; set; }
        public string Rue { get; set; }

        public double CGLatitude { get; set; }
        public double CGLongitude { get; set; }
        public Hotel()
        {
        }

        public Hotel(G.Hotel entity)
        {
            Id = entity.Id;
            Nom = entity.Nom;
            NombreEtoile = entity.NombreEtoile;
            Telephone = entity.Telephone;
            Email = entity.Email;
            NombreChambre = entity.NombreChambre;
            Ville = entity.Ville;
            Pays = entity.Pays;
            AdresseId = entity.AdresseId;
            CP = entity.CP;
            Num = entity.Num;
            Rue = entity.Rue;
            CGLatitude = entity.CGLatitude;
            CGLongitude = entity.CGLongitude;

        }

        
    }
}

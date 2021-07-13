using Projet.DALClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Web.Mvc;

namespace ProjetASP.API.Models
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




        public Hotel(Projet.DALClient.Models.Hotel hotel)
        {
            Id = hotel.Id;
            Nom = hotel.Nom;
            NombreEtoile = hotel.NombreEtoile;
            Telephone = hotel.Telephone;
            Email = hotel.Email;
            NombreChambre = hotel.NombreChambre;
            Ville = hotel.Ville;
            Pays = hotel.Pays;
            AdresseId = hotel.AdresseId;
            CP = hotel.CP;
            Num = hotel.Num;
            Rue = hotel.Rue;
      
            CGLatitude = hotel.CGLatitude;
            CGLongitude = hotel.CGLongitude;
       

        }
        public Hotel()
        {
        }
        
        
    }
    

}
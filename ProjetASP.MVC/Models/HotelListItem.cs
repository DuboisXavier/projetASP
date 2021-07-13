using ProjetASP.MVC.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetASP.MVC.Models
{
    public class HotelListItem
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public int NombreEtoile { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }
        public int NombreChambre { get; set; }
        public string Ville { get; set; }
        public string Pays { get; set; }
        public int CP { get; set; }
        public int Num { get; set; }
        public string Rue { get; set; }
        public double CGLatitude { get; set; }
        public double CGLongitude { get; set; }


    }
}
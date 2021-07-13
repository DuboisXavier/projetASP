using ProjetASP.MVC.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetASP.MVC.Models
{
    public class HotelDetails
    {

        public int Id { get; set; }
        [Required]
        public string Nom { get; set; }
        [Required]
        public int NombreEtoile { get; set; }
        [Required]
        public string Telephone { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public int NombreChambre { get; set; }
        [Required]
        public string Ville { get; set; }
        [Required]
        public string Pays { get; set; }
        [Required]
        public int CP { get; set; }
        [Required]
        public int Num { get; set; }
        [Required]
        public string Rue { get; set; }
        [Required]
        public double CGLatitude { get; set; }
        [Required]
        public double CGLongitude { get; set; }
      
        public int AdresseId { get; set; }



    }
}
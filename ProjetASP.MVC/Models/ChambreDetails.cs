using ProjetASP.MVC.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetASP.MVC.Models
{
    public class ChambreDetails
    {
        public int Id { get; set; }
        [Required]
        public int Numero { get; set; }
        [Required]
        public string DescriptionC { get; set; }
        [Required]
        public string DescriptionL { get; set; }
        [Required]
        public string TypeDeChambre { get; set; }
        [Required]
        public int Capacite { get; set; }
        [Required]
        public int NombreDeSDB { get; set; }
        [Required]
        public int NombreDeWC { get; set; }
        [Required]

        public double Prix { get; set; }
        public int HotelId { get; set; }
        public string Nom { get; set; }

        //private HotelService _hotelService = new HotelService();

        //public IEnumerable<HotelListItem> ListHotel { get => _hotelService.Get(); }

    }
}
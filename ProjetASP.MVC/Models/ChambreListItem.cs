using ProjetASP.MVC.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetASP.MVC.Models
{
    public class ChambreListItem
    {
        public int Id { get; set; }
        public int Numero { get; set; }
        public string DescriptionC { get; set; }
        public string DescriptionL { get; set; }
        public string TypeDeChambre { get; set; }
        public int Capacite { get; set; }
        public int NombreDeSDB { get; set; }
        public int NombreDeWC { get; set; }

        public double Prix { get; set; }
        public int HotelId { get; set; }
        public string Nom { get; set; }

        

        //private HotelService _hotelService = new HotelService();

        //public IEnumerable<HotelListItem> ListHotel { get => _hotelService.Get(); }


    }
}
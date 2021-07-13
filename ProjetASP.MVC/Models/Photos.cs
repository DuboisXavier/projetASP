using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetASP.MVC.Models
{
    public class Photos
    {
        public int Id { get; set; }
        public string Photo { get; set; }
        public int HotelId { get; set; }
        public int ChambreId { get; set; }
    }
}
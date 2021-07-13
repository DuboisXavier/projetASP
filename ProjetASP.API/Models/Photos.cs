using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetASP.API.Models
{
    public class Photos
    {
        public int Id { get; set; }
        public string Photo { get; set; }
        public int HotelId { get; set; }
        public int ChambreId { get; set; }
        public Photos(Projet.DALClient.Models.Photos p)
        {
            Id = p.Id;
            Photo = p.Photo;
            HotelId = p.HotelId;
            ChambreId = p.ChambreId;


        }
        public Photos()
        {
        }
    }
}
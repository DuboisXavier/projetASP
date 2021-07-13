using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using G = Projet.DALGlobal.Models;

namespace Projet.DALClient.Models
{
    public class Photos
    {
        public int Id { get; set; }
        public string Photo { get; set; }
        public int HotelId { get; set; }
        public int ChambreId { get; set; }

        public Photos(G.Photos entity)
        {
            Id = entity.Id;
            HotelId = entity.HotelId;
            ChambreId = entity.ChambreId;
        }
            public Photos()
        {
        }
    }
}

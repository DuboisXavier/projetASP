using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet.DALGlobal.Models
{
    public class Photos
    {
        public int Id { get; set; }
        public string Photo { get; set; }
        public int HotelId { get; set; }
        public int ChambreId { get; set; }
    }
}

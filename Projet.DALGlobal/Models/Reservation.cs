using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet.DALGlobal.Models
{
    public class Reservation
    {
        public int Id { get; set; }
        public DateTime DateDebut { get; set; }
        public DateTime DateFin { get; set; }
        public int NombreDePersonnes { get; set; }
        public int UtilisateurId { get; set; }
        public int ChambreId { get; set; }
        public string Nom { get; set; }



        public Reservation()
        {

        }
    }
}

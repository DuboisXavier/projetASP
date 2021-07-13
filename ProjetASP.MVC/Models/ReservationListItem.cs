using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetASP.MVC.Models
{
    public class ReservationListItem
    {
        public int Id { get; set; }
        public DateTime DateDebut { get; set; }
        public DateTime DateFin { get; set; }
        public int NombreDePersonnes { get; set; }
        public int UtilisateurId { get; set; }
        public int ChambreId { get; set; }

        public string Nom { get; set; }
    }
}
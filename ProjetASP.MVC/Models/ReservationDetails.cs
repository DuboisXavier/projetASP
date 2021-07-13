using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetASP.MVC.Models
{
    public class ReservationDetails
    {
        public int Id { get; set; }
        [Required]
        public DateTime DateDebut { get; set; }
        [Required]
        public DateTime DateFin { get; set; }
        [Required]

        public int NombreDePersonnes { get; set; }
        public int UtilisateurId { get; set; }
        public int ChambreId { get; set; }
        public string Nom { get; set; }
    }
}
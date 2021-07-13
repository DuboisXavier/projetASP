using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetASP.API.Models
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

        public Reservation(Projet.DALClient.Models.Reservation reservation)
        {
            Id = reservation.Id;
            DateDebut = reservation.DateDebut;
            DateFin = reservation.DateFin;
            NombreDePersonnes = reservation.NombreDePersonnes;
            UtilisateurId = reservation.UtilisateurId;
            ChambreId = reservation.ChambreId;
        }
            public Reservation()
        {

        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using G = Projet.DALGlobal.Models;


namespace Projet.DALClient.Models
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

        public Reservation(G.Reservation entity)
        {
            Id = entity.Id;
            DateDebut = entity.DateDebut;
            DateFin = entity.DateFin;
            NombreDePersonnes = entity.NombreDePersonnes;
            UtilisateurId = entity.UtilisateurId;
            ChambreId = entity.ChambreId;
            Nom = entity.Nom;



        }
        public Reservation()
        {

        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using A = ProjetASP.API.Models;
using C = Projet.DALClient.Models;

namespace ProjetASP.API.Mapper
{
    public static class ReservationMapper
    {
        public static C.Reservation ToClient(this A.Reservation entity)
        {
            if (entity == null) return null;
            return new C.Reservation
            {
                Id = entity.Id,
                DateDebut = entity.DateDebut,
                DateFin = entity.DateFin,
                NombreDePersonnes = entity.NombreDePersonnes,
                UtilisateurId = entity.UtilisateurId,
                ChambreId = entity.ChambreId,
                Nom = entity.Nom

            };
        }
        public static A.Reservation ToAPI(this C.Reservation entity)
        {
            if (entity == null) return null;
            return new A.Reservation(entity);
        }
    }
}
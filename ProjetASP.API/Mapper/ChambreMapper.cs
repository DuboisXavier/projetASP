using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using A = ProjetASP.API.Models;
using C = Projet.DALClient.Models;

namespace ProjetASP.API.Mapper
{
    public static class ChambreMapper
    {
        public static C.Chambre ToClient(this A.Chambre entity)
        {
            if (entity == null) return null;
            return new C.Chambre
            {
                Id = entity.Id,
                Numero = entity.Numero,
                DescriptionC = entity.DescriptionC,
                DescriptionL = entity.DescriptionL,
                TypeDeChambre = entity.TypeDeChambre,
                Capacite = entity.Capacite,
                NombreDeSDB = entity.NombreDeSDB,
                NombreDeWC = entity.NombreDeWC,
                Prix = entity.Prix,
                HotelId = entity.HotelId,
                Nom = entity.Nom

            };
        }
        public static A.Chambre ToAPI(this C.Chambre entity)
        {
            if (entity == null) return null;
            return new A.Chambre(entity);
        }
    }
}
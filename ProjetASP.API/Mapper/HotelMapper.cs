
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using A = ProjetASP.API.Models;
using C = Projet.DALClient.Models;


namespace ProjetASP.API.Mapper
{
    public static class HotelMapper
    {
        public static C.Hotel ToClient(this A.Hotel entity)
        {
            if (entity == null) return null;
            return new C.Hotel
            {
                Id = entity.Id,
                Nom = entity.Nom,
                NombreEtoile = entity.NombreEtoile,
                Telephone = entity.Telephone,
                Email = entity.Email,
                NombreChambre = entity.NombreChambre,
                Ville = entity.Ville,
                Pays = entity.Pays,
                AdresseId = entity.AdresseId,
                CP = entity.CP,
                Num = entity.Num,
                Rue = entity.Rue,
            
                CGLatitude = entity.CGLatitude,
                CGLongitude = entity.CGLongitude
       

            };
        }
        public static A.Hotel ToAPI(this C.Hotel entity)
        {
            if (entity == null) return null;
            return new A.Hotel(entity);
        }
        
       
    }
}
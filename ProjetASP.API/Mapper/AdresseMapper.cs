using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using A = ProjetASP.API.Models;
using C = Projet.DALClient.Models;

namespace ProjetASP.API.Mapper
{
    public static class AdresseMapper
    {
        public static C.Adresse ToClient(this A.Adresse entity)
        {
            if (entity == null) return null;
            return new C.Adresse
            {
                Id = entity.Id,
                CP = entity.CP,
                Num = entity.Num,
                Rue = entity.Rue,
                Pays = entity.Pays,
                CGLatitude = entity.CGLatitude,
                CGLongitude = entity.CGLongitude,
                Ville = entity.Ville


            };
        }
        public static A.Adresse ToAPI(this C.Adresse entity)
        {
            if (entity == null) return null;
            return new A.Adresse(entity);
        }
    }
}
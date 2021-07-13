
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using A = ProjetASP.API.Models;
using C = Projet.DALClient.Models;
namespace ProjetASP.API.Mapper
{
    public static class UtilisateurMapper
    {
        public static C.Utilisateur ToClient(this A.Utilisateur entity)
        {
            if (entity == null) return null;
            return new C.Utilisateur
            {
                Id = entity.Id,
                Nom = entity.Nom,
                Prenom = entity.Prenom,
                AdresseMail = entity.AdresseMail,
                Telephone = entity.Telephone,
                MotDePasse = entity.MotDePasse,
                Roles = entity.Roles,
                AdresseId = entity.AdresseId,
                Ville = entity.Ville,
                Pays = entity.Pays,
                CP = entity.CP,
                Num = entity.Num,
                Rue = entity.Rue,

                CGLatitude = entity.CGLatitude,
                CGLongitude = entity.CGLongitude

            };
        }
        public static A.Utilisateur ToAPI(this C.Utilisateur entity)
        {
            if (entity == null) return null;
            return new A.Utilisateur(entity);
        }
    }
}
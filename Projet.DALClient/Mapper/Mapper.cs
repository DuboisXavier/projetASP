using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using G = Projet.DALGlobal.Models;
using C = Projet.DALClient.Models;


namespace Projet.DALClient.Mapper
{
    public static class Mapper
    {
        public static G.Hotel ToGlobal(this C.Hotel entity)
        {
            if (entity == null) return null;
            return new G.Hotel
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
        public static C.Hotel ToClient(this G.Hotel entity)
        {
            if (entity == null) return null;
            return new C.Hotel(entity);
        }

        public static G.Adresse ToGlobal(this C.Adresse entity)
        {
            if (entity == null) return null;
            return new G.Adresse
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

        public static C.Adresse ToClient(this G.Adresse entity)
        {
            if (entity == null) return null;
            return new C.Adresse(entity);
        }

        public static G.Chambre ToGlobal(this C.Chambre entity)
        {
            if (entity == null) return null;
            return new G.Chambre
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

        public static C.Chambre ToClient(this G.Chambre entity)
        {
            if (entity == null) return null;
            return new C.Chambre(entity);
        }
        public static G.Role ToGlobal(this C.Role entity)
        {
            if (entity == null) return null;
            return new G.Role
            {
                Id = entity.Id,
                Nom = entity.Nom

            };
        }

        public static C.Role ToClient(this G.Role entity)
        {
            if (entity == null) return null;
            return new C.Role(entity);
        }
        public static G.Utilisateur ToGlobal(this C.Utilisateur entity)
        {
            if (entity == null) return null;
            return new G.Utilisateur
            {
                Id = entity.Id,
                Nom = entity.Nom,
                Prenom = entity.Prenom,
                AdresseMail = entity.AdresseMail,
                Telephone = entity.Telephone,
                MotDePasse = entity.MotDePasse,
                Roles = entity.Roles,
                AdresseId = entity.AdresseId,
                CP = entity.CP,
                Num = entity.Num,
                Rue = entity.Rue,
                Ville = entity.Ville,
                Pays = entity.Pays,
                CGLatitude = entity.CGLatitude,
                CGLongitude = entity.CGLongitude

            };
        }

        public static C.Utilisateur ToClient(this G.Utilisateur entity)
        {
            if (entity == null) return null;
            return new C.Utilisateur(entity);
        }
        public static G.Reservation ToGlobal(this C.Reservation entity)
        {
            if (entity == null) return null;
            return new G.Reservation
            {
                Id = entity.Id,
                DateDebut = entity.DateDebut,
                DateFin = entity.DateFin,
                NombreDePersonnes = entity.NombreDePersonnes,
                UtilisateurId = entity.UtilisateurId,
                ChambreId = entity.ChambreId
              

            };
        }

        public static C.Reservation ToClient(this G.Reservation entity)
        {
            if (entity == null) return null;
            return new C.Reservation(entity);
        }
        public static G.Photos ToGlobal(this C.Photos entity)
        {
            if (entity == null) return null;
            return new G.Photos
            {
                Id = entity.Id,
                HotelId = entity.HotelId,
                ChambreId = entity.ChambreId


            };
        }

        public static C.Photos ToClient(this G.Photos entity)
        {
            if (entity == null) return null;
            return new C.Photos(entity);
        }
    }
}

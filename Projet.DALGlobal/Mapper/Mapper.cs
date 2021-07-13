using Projet.DALGlobal.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet.DALGlobal.Mapper
{
    public static class Mapper
    {
        public static Hotel ToHotel(this IDataRecord reader)
        {
            if (reader == null) return null;
            return new Hotel
            {
                Id = (int)reader[nameof(Hotel.Id)],
                Nom = (string)reader[nameof(Hotel.Nom)],
                NombreEtoile = (int)reader[nameof(Hotel.NombreEtoile)],
                Telephone = (string)reader[nameof(Hotel.Telephone)],
                NombreChambre = (int)reader[nameof(Hotel.NombreChambre)],
                Email = (string)reader[nameof(Hotel.Email)],
                Ville = (string)reader[nameof(Hotel.Ville)],
                Pays = (string)reader[nameof(Hotel.Pays)],
                AdresseId = (int)reader[nameof(Hotel.AdresseId)],
                //CP = (int)reader[nameof(Hotel.CP)],
                //Num = (int)reader[nameof(Hotel.Num)],
                //Rue = (string)reader[nameof(Hotel.Rue)],
               
                //CGLatitude = (double)reader[nameof(Hotel.CGLatitude)],
                //CGLongitude = (double)reader[nameof(Hotel.CGLongitude)]
               
            };
        }

        public static Adresse ToAdresse(this IDataRecord reader)
        {
            if (reader == null) return null;
            return new Adresse
            {
                Id = (int)reader[nameof(Adresse.Id)],
                CP = (int)reader[nameof(Adresse.CP)],
                Num = (int)reader[nameof(Adresse.Num)],
                Rue = (string)reader[nameof(Adresse.Rue)],
                Pays = (string)reader[nameof(Adresse.Pays)],
                CGLatitude = (double)reader[nameof(Adresse.CGLatitude)],
                CGLongitude = (double)reader[nameof(Adresse.CGLongitude)],
                Ville = (string)reader[nameof(Adresse.Ville)]
                
            };
        }

        public static Chambre ToChambre(this IDataRecord reader)
        {
            if (reader == null) return null;
            return new Chambre
            {
                Id = (int)reader[nameof(Chambre.Id)],
                Numero = (int)reader[nameof(Chambre.Numero)],
                DescriptionC = (string)reader[nameof(Chambre.DescriptionC)],
                DescriptionL = (string)reader[nameof(Chambre.DescriptionL)],
                TypeDeChambre = (string)reader[nameof(Chambre.TypeDeChambre)],
                Capacite = (int)reader[nameof(Chambre.Capacite)],
                NombreDeSDB = (int)reader[nameof(Chambre.NombreDeSDB)],
                NombreDeWC = (int)reader[nameof(Chambre.NombreDeWC)],
                Prix = (double)reader[nameof(Chambre.Prix)],                          
                HotelId = (int)reader[nameof(Chambre.HotelId)],
                //Nom = (string)reader[nameof(Chambre.Nom)]
            };
        }

        public static Role ToRole(this IDataRecord reader)
        {
            if (reader == null) return null;
            return new Role
            {
                Id = (int)reader[nameof(Role.Id)],
                Nom = (string)reader[nameof(Role.Nom)]
              
            };
        }
        public static Utilisateur ToUtilisateur(this IDataRecord reader)
        {
            if (reader == null) return null;
            return new Utilisateur
            {
                Id = (int)reader[nameof(Utilisateur.Id)],  
                Nom = (string)reader[nameof(Utilisateur.Nom)],
                Prenom = (string)reader[nameof(Utilisateur.Prenom)],
                AdresseMail = (string)reader[nameof(Utilisateur.AdresseMail)],
                Telephone = (string)reader[nameof(Utilisateur.Telephone)],
                Roles = (string)reader[nameof(Utilisateur.Roles)],
                AdresseId = (int)reader[nameof(Utilisateur.AdresseId)],
                

            };
        }
        public static Reservation ToReservation(this IDataRecord reader)
        {
            if (reader == null) return null;
            return new Reservation
            {
                Id = (int)reader[nameof(Reservation.Id)],
                DateDebut = (DateTime)reader[nameof(Reservation.DateDebut)],
                DateFin = (DateTime)reader[nameof(Reservation.DateFin)],
                NombreDePersonnes = (int)reader[nameof(Reservation.NombreDePersonnes)],
                UtilisateurId = (int)reader[nameof(Reservation.UtilisateurId)],
                ChambreId = (int)reader[nameof(Reservation.ChambreId)],
                

            };
        }
        public static Photos ToPhotos(this IDataRecord reader)
        {
            if (reader == null) return null;
            return new Photos
            {
                Id = (int)reader[nameof(Photos.Id)],
                Photo = (string)reader[nameof(Photos.Photo)],
                HotelId = (int)reader[nameof(Photos.HotelId)],
                ChambreId = (int)reader[nameof(Photos.ChambreId)],
            };
        }


    }
}

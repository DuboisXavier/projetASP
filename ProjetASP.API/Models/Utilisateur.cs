using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetASP.API.Models
{
    public class Utilisateur
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string AdresseMail { get; set; }
        public string Telephone { get; set; }
        public string MotDePasse { get; set; }
        public string Roles { get; set; }
        public int AdresseId { get; set; }
        public int CP { get; set; }
        public int Num { get; set; }
        public string Rue { get; set; }
        public string Pays { get; set; }
        public double CGLatitude { get; set; }
        public double CGLongitude { get; set; }

        public string Ville { get; set; }
        public Utilisateur(Projet.DALClient.Models.Utilisateur utilisateur)
        {
            Id = utilisateur.Id;
            Nom = utilisateur.Nom;
            Prenom = utilisateur.Prenom;
            AdresseMail = utilisateur.AdresseMail;
            Telephone = utilisateur.Telephone;
            Roles = utilisateur.Roles;
            AdresseId = utilisateur.AdresseId;
            CP = utilisateur.CP;
            Num = utilisateur.Num;
            Rue = utilisateur.Rue;
            Pays = utilisateur.Pays;
            CGLatitude = utilisateur.CGLatitude;
            CGLongitude = utilisateur.CGLongitude;
            Ville = utilisateur.Ville;

        }
        public Utilisateur()
        {

        }
    }
}
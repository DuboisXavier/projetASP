using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using G = Projet.DALGlobal.Models;


namespace Projet.DALClient.Models
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
        public Utilisateur(G.Utilisateur entity)
        {
            Id = entity.Id;
            Nom = entity.Nom;
            Prenom = entity.Prenom;
            AdresseMail = entity.AdresseMail;
            Telephone = entity.Telephone;
            MotDePasse = entity.MotDePasse;
            Roles = entity.Roles;
            AdresseId = entity.AdresseId;
            CP = entity.CP;
            Num = entity.Num;
            Rue = entity.Rue;
            Pays = entity.Pays;
            CGLatitude = entity.CGLatitude;
            CGLongitude = entity.CGLongitude;
            Ville = entity.Ville;


        }
        public Utilisateur()
        {

        }
    }
}

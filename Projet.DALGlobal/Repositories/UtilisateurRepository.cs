using Projet.DALGlobal.Mapper;
using Projet.DALGlobal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolBox.ADO;

namespace Projet.DALGlobal.Repositories
{
    public class UtilisateurRepository : BasicRepository, IUtilisateur<int, Utilisateur>
    {
        private const string SELECT = "SELECT Id, Nom, Prenom, AdresseMail, Telephone, MotDePasse, Roles, AdresseId FROM Utilisateur";
        public bool Delete(int id)
        {
            Command command = new Command("Delete FROM Utilisateur WHERE Id = @Id");
            command.AddParameter("Id", id);
            _connection.ExecuteNonQuery(command);
            return true;
        }
        public IEnumerable<Utilisateur> Get()
        {
            Command command = new Command($"{SELECT}");
            return _connection.ExecuteReader(command, (reader) => reader.ToUtilisateur());
        }
        public Utilisateur Get(int id)
        {
            Command command = new Command($"{SELECT} WHERE Utilisateur.Id = @Id");
            command.AddParameter("Id", id);
            return _connection.ExecuteReader(command, (reader) => reader.ToUtilisateur()).SingleOrDefault();
        }
        public int Insert(Utilisateur entity)
        {
            Command command = new Command("CreationUtilisateur", true);
            command.AddParameter("Nom", entity.Nom);
            command.AddParameter("Prenom", entity.Prenom);
            command.AddParameter("AdresseMail", entity.AdresseMail);
            command.AddParameter("Telephone", entity.Telephone);
            command.AddParameter("Roles", entity.Roles);
            command.AddParameter("CP", entity.CP);
            command.AddParameter("Num", entity.Num);
            command.AddParameter("Rue", entity.Rue);
            command.AddParameter("Pays", entity.Pays);
            command.AddParameter("CGLongitude", entity.CGLongitude);
            command.AddParameter("CGLatitude", entity.CGLatitude);
            command.AddParameter("Ville", entity.Ville);

            return _connection.ExecuteNonQuery(command);
        }
        public int Update(int id, Utilisateur entity)
        {
            Command command = new Command("Update Utilisateur SET Nom=@Nom, Prenom=@Prenom, AdresseMail=@AdresseMail, Telephone=@Telephone, MotDePasse=@MotDePasse, Roles=@Roles, AdresseId=@AdresseId Where Id=@Id");
            command.AddParameter("Id", id);
            command.AddParameter("Nom", entity.Nom);
            command.AddParameter("Prenom", entity.Prenom);
            command.AddParameter("AdresseMail", entity.AdresseMail);
            command.AddParameter("Telephone", entity.Telephone);
            command.AddParameter("Roles", entity.Roles);
            command.AddParameter("AdresseId", entity.AdresseId);

            return _connection.ExecuteNonQuery(command);
        }
  
    }
}

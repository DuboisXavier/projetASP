using Projet.DALGlobal.Mapper;
using Projet.DALGlobal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolBox.ADO;

namespace Projet.DALGlobal.Repositories.AuthRepository
{
    public class AuthRepository : BasicRepository, IAuthRepository<int, Utilisateur>
    {
        public int Register(Utilisateur form)
        {
            try
            {
                Command command = new Command("CreationUtilisateur", true);
                command.AddParameter("Nom", form.Nom);
                command.AddParameter("Prenom", form.Prenom);
                command.AddParameter("AdresseMail", form.AdresseMail);
                command.AddParameter("Telephone", form.Telephone);
                command.AddParameter("MotDePasse", form.MotDePasse);
                command.AddParameter("Roles", form.Roles);
                command.AddParameter("CP", form.CP);
                command.AddParameter("Num", form.Num);
                command.AddParameter("Rue", form.Rue);
                command.AddParameter("Pays", form.Pays);
                command.AddParameter("CGLongitude", form.CGLongitude);
                command.AddParameter("CGLatitude", form.CGLatitude);
                command.AddParameter("Ville", form.Ville);


                return _connection.ExecuteNonQuery(command);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Utilisateur Login(Utilisateur form)
        {
            try
            {
                Command command = new Command("CheckUser", true);

                command.AddParameter("AdresseMail", form.AdresseMail);
                command.AddParameter("MotDePasse", form.MotDePasse);

                Utilisateur user = (Utilisateur)_connection.ExecuteReader(command, (reader) => reader.ToUtilisateur()).SingleOrDefault();

                return user;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

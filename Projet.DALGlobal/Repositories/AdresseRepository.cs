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
    public class AdresseRepository : BasicRepository, IAdresse<int, Adresse>
    {
        public bool Delete(int id)
        {
            Command command = new Command("DELETE FROM Adresse WHERE id = @id");
            command.AddParameter("id", id);
            return _connection.ExecuteNonQuery(command) > 0;
        }

        public IEnumerable<Adresse> Get()
        {
            Command command = new Command("SELECT Id, CP, Num, Rue, Pays, CGLatitude, CGLongitude, Ville FROM Adresse");
            return _connection.ExecuteReader(command, (reader) => reader.ToAdresse());
        }

        public Adresse Get(int id)
        {
            Command command = new Command("SELECT Id, CP, Num, Rue, Pays, CGLatitude, CGLongitude, Ville FROM Adresse WHERE id = @id");
            command.AddParameter("id", id);
            return _connection.ExecuteReader(command, (reader) => reader.ToAdresse()).SingleOrDefault();
        }

        public int Insert(Adresse entity)
        {
            Command command = new Command("Insert INTO Adresse(CP, Num, Rue, Pays, CGLongitude, CGLatitude, Ville) VALUES(@CP, @Num, @Rue, @Pays, @CGLongitude, @CGLatitude, @Ville)");
            command.AddParameter("CP", entity.CP);
            command.AddParameter("Num", entity.Num);
            command.AddParameter("Rue", entity.Rue);
            command.AddParameter("Pays", entity.Pays);
            command.AddParameter("CGLongitude", entity.CGLongitude);
            command.AddParameter("CGLatitude", entity.CGLatitude);
            command.AddParameter("Ville", entity.Ville);
           
            return _connection.ExecuteNonQuery(command);
        }

        public int Update(int id, Adresse entity)
        {
            Command command = new Command("Update Adresse SET CP=@CP, Num=@Num, Rue=@Rue, Pays=@Pays, CGLongitude=@CGLongitude, CGLatitude=@CGLatitude, Ville=@Ville Where Id=@Id");
            command.AddParameter("CP", entity.CP);
            command.AddParameter("Num", entity.Num);
            command.AddParameter("Rue", entity.Rue);
            command.AddParameter("Pays", entity.Pays);
            command.AddParameter("CGLongitude", entity.CGLongitude);
            command.AddParameter("CGLatitude", entity.CGLatitude);
            command.AddParameter("Ville", entity.Ville);

            return _connection.ExecuteNonQuery(command);
        }


    }
}



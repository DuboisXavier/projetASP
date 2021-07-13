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
    public class HotelRepository : BasicRepository, IHotel<int, Hotel>
    {
        private const string SELECT = "SELECT Hotel.Id, Nom, NombreEtoile, Telephone, Email, NombreChambre, Adresse.Ville, Adresse.Pays, AdresseId FROM Hotel INNER JOIN Adresse ON Hotel.AdresseId = Adresse.Id";
        public bool Delete(int id)
        {
            Command command = new Command("Delete FROM Hotel WHERE Id = @Id");
            command.AddParameter("Id", id);
            _connection.ExecuteNonQuery(command);
            return true;
        }


        public IEnumerable<Hotel> Get()
        {
            Command command = new Command($"{SELECT}");
            return _connection.ExecuteReader(command, (reader) => reader.ToHotel());
        }

        public Hotel Get(int id)
        {
            Command command = new Command($"{SELECT} WHERE Hotel.Id = @Id");
            command.AddParameter("Id", id);
            return _connection.ExecuteReader(command, (reader) => reader.ToHotel()).SingleOrDefault();
        }

        public int Insert(Hotel entity)
        {
            Command command = new Command("CreationHotel", true);
            command.AddParameter("Nom", entity.Nom);
            command.AddParameter("NombreEtoile", entity.NombreEtoile);
            command.AddParameter("Telephone", entity.Telephone);
            command.AddParameter("Email", entity.Email);
            command.AddParameter("NombreChambre", entity.NombreChambre);
            command.AddParameter("CP", entity.CP);
            command.AddParameter("Num", entity.Num);
            command.AddParameter("Rue", entity.Rue);
            command.AddParameter("Pays", entity.Pays);
            command.AddParameter("CGLongitude", entity.CGLongitude);
            command.AddParameter("CGLatitude", entity.CGLatitude);
            command.AddParameter("Ville", entity.Ville);





            return _connection.ExecuteNonQuery(command);
        }

        public int Update(int id, Hotel entity)
        {
            Command command = new Command("Update Hotel SET Nom=@Nom, NombreEtoile=@NombreEtoile, Telephone=@Telephone, Email=@Email, NombreChambre=@NombreChambre, AdresseId=@AdresseId Where Id=@Id");
            command.AddParameter("Id", id);
            command.AddParameter("Nom", entity.Nom);
            command.AddParameter("NombreEtoile", entity.NombreEtoile);
            command.AddParameter("Telephone", entity.Telephone);
            command.AddParameter("Email", entity.Email);
            command.AddParameter("NombreChambre", entity.NombreChambre);
            command.AddParameter("AdresseId", entity.AdresseId);

            return _connection.ExecuteNonQuery(command);
        }

    }
}


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
    public class ChambreRepository : BasicRepository, IChambre<int, Chambre>
    {
        public bool Delete(int id)
        {
            Command command = new Command("Delete FROM Chambre WHERE Id = @Id");
            command.AddParameter("Id", id);
            _connection.ExecuteNonQuery(command);
            return true;
        }

        public IEnumerable<Chambre> Get()
        {
            Command command = new Command("SELECT Chambre.Id, Numero, DescriptionC, DescriptionL, TypeDeChambre, Capacite, NombreDeSDB, NombreDeWC, Prix, Hotel.Nom, HotelId FROM Chambre INNER JOIN Hotel ON Chambre.HotelId = Hotel.Id");
            return _connection.ExecuteReader(command, (reader) => reader.ToChambre());
        }
        //public IEnumerable<Chambre> GetByHotel(int id)
        //{
        //    Command command = new Command(" Select Chambre.HotelId, Chambre.Numero, Hotel.Nom as HotelNom FROM Chambre LEFT JOIN Hotel on Chambre.Id = Hotel.Id WHERE Chambre.HotelId = @Id");
        //    command.AddParameter("id", id);
        //    return _connection.ExecuteReader(command, (reader) => reader.ToChambre());
        //}
        public Chambre Get(int id)
        {
            Command command = new Command("SELECT Id, Numero, DescriptionC, DescriptionL, TypeDeChambre, Capacite, NombreDeSDB, NombreDeWC, Prix, HotelId FROM Chambre WHERE id = @id");
            command.AddParameter("id", id);
            return _connection.ExecuteReader(command, (reader) => reader.ToChambre()).SingleOrDefault();
        }


        public int Insert(Chambre entity)
        {
            Command command = new Command("Insert INTO Chambre(Numero, DescriptionC, DescriptionL, TypeDeChambre, Capacite, NombreDeSDB, NombreDeWC, Prix, HotelId) VALUES(@Numero, @DescriptionC, @DescriptionL, @TypeDeChambre, @Capacite, @NombreDeSDB, @NombreDeWC, @Prix, @HotelId)");
            command.AddParameter("Numero", entity.Numero);
            command.AddParameter("DescriptionC", entity.DescriptionC);
            command.AddParameter("DescriptionL", entity.DescriptionL);
            command.AddParameter("TypeDeChambre", entity.TypeDeChambre);
            command.AddParameter("Capacite", entity.Capacite);
            command.AddParameter("NombreDeSDB", entity.NombreDeSDB);
            command.AddParameter("NombreDeWC", entity.NombreDeWC);
            command.AddParameter("Prix", entity.Prix);
            command.AddParameter("HotelId", entity.HotelId);

            return _connection.ExecuteNonQuery(command);
        }

        public int Update(int id, Chambre entity)
        {
            Command command = new Command("Update Chambre SET Numero=@Numero, DescriptionC=@DescriptionC, DescriptionL=@DescriptionL, TypeDeChambre=@TypeDeChambre, Capacite=@Capacite, NombreDeSDB=@NombreDeSDB, NombreDeWC=@NombreDeWC, Prix=@Prix, HotelId=@HotelId Where Id=@Id");
            command.AddParameter("Id", id);
            command.AddParameter("Numero", entity.Numero);
            command.AddParameter("DescriptionC", entity.DescriptionC);
            command.AddParameter("DescriptionL", entity.DescriptionL);
            command.AddParameter("TypeDeChambre", entity.TypeDeChambre);
            command.AddParameter("Capacite", entity.Capacite);
            command.AddParameter("NombreDeSDB", entity.NombreDeSDB);
            command.AddParameter("NombreDeWC", entity.NombreDeWC);
            command.AddParameter("Prix", entity.Prix);
            command.AddParameter("HotelId", entity.HotelId);

            return _connection.ExecuteNonQuery(command);
        }

    }
}

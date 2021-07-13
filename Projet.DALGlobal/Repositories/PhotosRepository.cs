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
    public class PhotosRepository : BasicRepository, IPhotos<int, Photos>
    {
        public bool Delete(int id)
        {
            Command command = new Command("Delete FROM Photos WHERE Id = @Id");
            command.AddParameter("Id", id);
            _connection.ExecuteNonQuery(command);
            return true;
        }
        public IEnumerable<Photos> Get()
        {
            Command command = new Command("SELECT Id, Photo, HotelId, ChambreId FROM Photos");
            return _connection.ExecuteReader(command, (reader) => reader.ToPhotos());
        }
        public Photos Get(int id)
        {
            Command command = new Command("SELECT Id, Photo, HotelId, ChambreId FROM Photos WHERE id = @id");
            command.AddParameter("id", id);
            return _connection.ExecuteReader(command, (reader) => reader.ToPhotos()).SingleOrDefault();
        }
        public int Insert(Photos entity)
        {
            Command command = new Command("Insert INTO Photos(Photo, HotelId, ChambreId) VALUES(@Photo, @HotelId, @ChambreId)");
            command.AddParameter("Photo", entity.Photo);
            command.AddParameter("HotelId", entity.HotelId);
            command.AddParameter("ChambreId", entity.ChambreId);
       
            return _connection.ExecuteNonQuery(command);
        }
        public int Update(int id, Photos photos)
        {
            Command command = new Command("Update Photos SET Photo=@Photo, HotelId=@HotelId, ChambreId=@ChambreId Where Id=@Id");
            command.AddParameter("Id", id);
            command.AddParameter("DateDebut", photos.Photo);
            command.AddParameter("DateFin", photos.HotelId);
            command.AddParameter("NombreDePersonnes", photos.ChambreId);
         


            return _connection.ExecuteNonQuery(command);
        }
    }
}

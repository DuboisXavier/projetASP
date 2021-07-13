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
    public class ReservationRepository : BasicRepository, IReservation<int, Reservation>
    {
        public bool Delete(int id)
        {
            Command command = new Command("Delete FROM Reservation WHERE Id = @Id");
            command.AddParameter("Id", id);
            _connection.ExecuteNonQuery(command);
            return true;
        }
        public IEnumerable<Reservation> Get()
        {
            Command command = new Command("SELECT Id, DateDebut, DateFin, NombreDePersonnes, UtilisateurId, ChambreId FROM Reservation");
            return _connection.ExecuteReader(command, (reader) => reader.ToReservation());
        }
        public Reservation Get(int id)
        {
            Command command = new Command("SELECT Id, DateDebut, DateFin, NombreDePersonnes, UtilisateurId, ChambreId FROM Reservation WHERE id = @id");
            command.AddParameter("id", id);
            return _connection.ExecuteReader(command, (reader) => reader.ToReservation()).SingleOrDefault();
        }

        public IEnumerable<Reservation> GetByUser(int id)
        {
            Command command = new Command("SELECT Id, DateDebut, DateFin, NombreDePersonnes, UtilisateurId, ChambreId FROM Reservation WHERE UtilisateurId = @Id");
            command.AddParameter("Id", id);
            return _connection.ExecuteReader(command, (reader) => reader.ToReservation());
        }

        public int Insert(Reservation entity)
        {
            Command command = new Command("Insert INTO Reservation(DateDebut, DateFin, NombreDePersonnes, UtilisateurId, ChambreId) VALUES(@DateDebut, @DateFin, @NombreDePersonnes, @UtilisateurId, @ChambreId)");
            command.AddParameter("DateDebut", entity.DateDebut);
            command.AddParameter("DateFin", entity.DateFin);
            command.AddParameter("NombreDePersonnes", entity.NombreDePersonnes);
            command.AddParameter("UtilisateurId", entity.UtilisateurId);
            command.AddParameter("ChambreId", entity.ChambreId);
          

            return _connection.ExecuteNonQuery(command);
        }
        public int Update(int id, Reservation reservation)
        {
            Command command = new Command("Update Reservation SET DateDebut=@DateDebut, DateFin=@DateFin, NombreDePersonnes=@NombreDePersonnes, UtilisateurId=@UtilisateurId, ChambreId=@ChambreId Where Id=@Id");
            command.AddParameter("Id", id);
            command.AddParameter("DateDebut", reservation.DateDebut);
            command.AddParameter("DateFin", reservation.DateFin);
            command.AddParameter("NombreDePersonnes", reservation.NombreDePersonnes);
            command.AddParameter("UtilisateurId", reservation.UtilisateurId);
            command.AddParameter("ChambreId", reservation.ChambreId);
          

            return _connection.ExecuteNonQuery(command);
        }
    }
}

using Projet.DALClient.Mapper;
using Projet.DALClient.Models;
using Projet.DALGlobal.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using G = Projet.DALGlobal.Models;
using C = Projet.DALClient.Models;

namespace Projet.DALClient.Services
{
    public class ReservationService : IReservation<int, C.Reservation>
    {
        private IReservation<int, G.Reservation> _reservationRepository;

        public ReservationService()
        {
            _reservationRepository = new ReservationRepository();
        }
        public bool Delete(int id)
        {
            return _reservationRepository.Delete(id);

        }
        public IEnumerable<C.Reservation> Get() // projet de la dal client
        {
            return _reservationRepository.Get().Select(p => p.ToClient()); // projet de la dal global
        }

        public C.Reservation Get(int id)
        {
            return _reservationRepository.Get(id).ToClient();
        }
        public int Insert(C.Reservation form)
        {
            G.Reservation reservation = new G.Reservation();
            reservation.DateDebut = form.DateDebut;
            reservation.DateFin = form.DateFin;
            reservation.NombreDePersonnes = form.NombreDePersonnes;
            reservation.UtilisateurId = form.UtilisateurId;
            reservation.ChambreId = form.ChambreId;
 

            return _reservationRepository.Insert(reservation);

        }
        public int Update(int id, C.Reservation form)
        {
            G.Reservation reservation = new G.Reservation();
            reservation.DateDebut = form.DateDebut;
            reservation.DateFin = form.DateFin;
            reservation.NombreDePersonnes = form.NombreDePersonnes;
            reservation.UtilisateurId = form.UtilisateurId;
            reservation.ChambreId = form.ChambreId;

            return _reservationRepository.Update(id, reservation);
        }

        public IEnumerable<C.Reservation> GetReservationByUser(int id)
        {
            return _reservationRepository.GetByUser(id).Select(p => p.ToClient());
        }
        //les 2 services implémente la meme interface
        public IEnumerable<G.Reservation> GetByUser(int id)
        {
            throw new NotImplementedException();
        }
    }
}

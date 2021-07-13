
using Projet.DALClient.Services;
using ProjetASP.API.Mapper;
using ProjetASP.API.Models;
using C = Projet.DALClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ProjetASP.API.Controllers
{
    public class ReservationController : ApiController
    {
        private ReservationService _reservationService;

        public ReservationController()
        {
            _reservationService = new ReservationService();
        }
        // GET: api/Reservation
        public IEnumerable<Reservation> Get()
        {
            return _reservationService.Get().Select(h => h.ToAPI());
        }

        //GET: api/Hotel/5

        public Reservation Get(int id)
        {
            return _reservationService.Get(id).ToAPI();
        }
        // POST: api/Hotel
        [HttpPost]
        public int Create([FromBody] C.Reservation form)
        {

            return _reservationService.Insert(form);
        }

        // POST: api/Reservation
        [HttpPut]
        public int Put(int id, [FromBody] C.Reservation form)
        {
            return _reservationService.Update(id, form);

        }

        // DELETE: api/Hotel/5
        public void Delete(int id)
        {
            _reservationService.Delete(id);
        }
        [HttpGet]
        [Route ("API/Reservation/User/{Id}")]
        public IEnumerable<Reservation>GetByUser(int Id)
        {
            return _reservationService.GetReservationByUser(Id).Select(h => h.ToAPI());
        }
    }
}

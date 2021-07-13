
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
    public class HotelController : ApiController
    {
        
        // GET: api/Hotel
        private HotelService _hotelService;
        
        public HotelController()
        {
            _hotelService = new HotelService();
        }

        public IEnumerable<Hotel> Get()
        {
            return _hotelService.Get().Select(h => h.ToAPI());
        }

        //GET: api/Hotel/5

        public Hotel Get(int id)
        {
            return _hotelService.Get(id).ToAPI();           
        }
        // POST: api/Hotel
        [HttpPost]
        public int Create([FromBody] C.Hotel form)
        {
          
            return _hotelService.Insert(form);
        }

        // PUT: api/Hotel/5
        [HttpPut]
        public int Put(int id, [FromBody] C.Hotel form)
        {
            return _hotelService.Update(id, form);

        }

        // DELETE: api/Hotel/5
        public void Delete(int id)
        {
            _hotelService.Delete(id);
        }
        
    }
}

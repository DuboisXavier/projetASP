
using Projet.DALClient.Services;
using ProjetASP.API.Mapper;
using ProjetASP.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using C = Projet.DALClient.Models;

namespace ProjetASP.API.Controllers
{
    public class ChambreController : ApiController
    {
        
        // GET: api/Chambre
        private ChambreService _chambreService;

        public ChambreController()
        {
            _chambreService = new ChambreService();
        }

        public IEnumerable<Chambre> Get()
        {

            return _chambreService.Get().Select(h => h.ToAPI());
        }

        //GET: api/Hotel/5

        public Chambre Get(int id)
        {
            return _chambreService.Get(id).ToAPI();
        }
        //public IEnumerable<Chambre> GetByHotel() // projet de la dal client
        //{

        //    return _chambreService.Get().Select(p => p.ToAPI()); // projet de la dal global
        //}
        //POST: api/Hotel
        [HttpPost]
        public int Create([FromBody] C.Chambre form)
        {

            return _chambreService.Insert(form);
        }

        // PUT: api/Hotel/5
        [HttpPut]
        public int Put(int id, [FromBody] C.Chambre form)
        {
            return _chambreService.Update(id, form);

        }
        // DELETE: api/Hotel/5
        public void Delete(int id)
        {
            _chambreService.Delete(id);
        }

    }
  
    
}

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
    public class AdresseController : ApiController
    {
        // GET: api/Adresse
        private AdresseService _adresseService;
        public AdresseController()
        {
            _adresseService = new AdresseService();
        }

        public IEnumerable<Adresse> Get()
        {
            IEnumerable<C.Adresse> bidule = _adresseService.Get();
            return _adresseService.Get().Select(h => h.ToAPI());
        }

        // GET: api/Adresse/5
        public Adresse Get(int id)
        {
            return _adresseService.Get(id).ToAPI();
        }

        // POST: api/Adresse
        [HttpPost]
        public int Create([FromBody] C.Adresse form)
        {

            return _adresseService.Insert(form);
        }

        // PUT: api/Adresse/5
        [HttpPut]
        public int Put(int id, [FromBody] C.Adresse form)
        {
            return _adresseService.Update(id, form);

        }

        // DELETE: api/Adresse/5
        public void Delete(int id)
        {
            _adresseService.Delete(id);
        }
    }
}

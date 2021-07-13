
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
    public class PhotosController : ApiController
    {
        // GET: api/Hotel
        private PhotosService _photosService;

        public PhotosController()
        {
            _photosService = new PhotosService();
        }

        public IEnumerable<Photos> Get()
        {
            return _photosService.Get().Select(h => h.ToAPI());
        }

        //GET: api/Photos/5

        public Photos Get(int id)
        {
            return _photosService.Get(id).ToAPI();
        }
        // POST: api/Photos
        [HttpPost]
        public int Create([FromBody] C.Photos form)
        {

            return _photosService.Insert(form);
        }

        // PUT: api/Photos/5
        [HttpPut]
        public int Put(int id, [FromBody] C.Photos form)
        {
            return _photosService.Update(id, form);

        }

        // DELETE: api/Photos/5
        public void Delete(int id)
        {
            _photosService.Delete(id);
        }

    }
}

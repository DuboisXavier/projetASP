
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
    public class RoleController : ApiController
    {
        private RoleService _roleService;

        public RoleController()
        {
            _roleService = new RoleService();
        }

        public IEnumerable<Role> Get()
        {
            return _roleService.Get().Select(h => h.ToAPI());
        }

        //GET: api/Hotel/5

        public Role Get(int id)
        {
            return _roleService.Get(id).ToAPI();
        }
        // POST: api/Hotel
        [HttpPost]
        public int Create([FromBody] C.Role form)
        {

            return _roleService.Insert(form);
        }

        // PUT: api/Hotel/5
        [HttpPut]
        public int Put(int id, [FromBody] C.Role form)
        {
            return _roleService.Update(id, form);

        }

        // DELETE: api/Hotel/5
        public void Delete(int id)
        {
            _roleService.Delete(id);
        }
    }
}
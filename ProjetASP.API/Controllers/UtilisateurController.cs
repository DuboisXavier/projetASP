
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
    public class UtilisateurController : ApiController
    {
        // GET: api/Utilisateur
        private UtilisateurService _utilisateurService;

        public UtilisateurController()
        {
            _utilisateurService = new UtilisateurService();
        }

        public IEnumerable<Utilisateur> Get()
        {
            return _utilisateurService.Get().Select(h => h.ToAPI());
        }

        //GET: api/Utilisateur/5

        public Utilisateur Get(int id)
        {
            return _utilisateurService.Get(id).ToAPI();
        }

        [Route("api/Auth/Login")]
        [HttpPost]
        public Utilisateur Login(Utilisateur utilisateur)
        {
            return _utilisateurService.CheckUser(utilisateur.ToClient()).ToAPI();
        }

        [Route("api/Auth/Register")]
        [HttpPost]
        public bool Register(Utilisateur utilisateur)
        {
            return _utilisateurService.RegisterUser(utilisateur.ToClient());
        }

        // POST: api/Utilisateur
        [HttpPost]
        public int Create([FromBody] C.Utilisateur form)
        {

            return _utilisateurService.Insert(form);
        }

        // PUT: api/Utilisateur/5
        [HttpPut]
        public int Put(int id, [FromBody] C.Utilisateur form)
        {
            return _utilisateurService.Update(id, form);

        }

        // DELETE: api/Hotel/5
        public void Delete(int id)
        {
            _utilisateurService.Delete(id);
        }
    }
}

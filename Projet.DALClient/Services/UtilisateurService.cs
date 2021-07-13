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
using Projet.DALGlobal.Repositories.AuthRepository;

namespace Projet.DALClient.Services
{
    public class UtilisateurService : IUtilisateur<int, C.Utilisateur>
    {
        private IUtilisateur<int, G.Utilisateur> _utilisateurRepository;
        private IAuthRepository<int, G.Utilisateur> _authRepository;


        public UtilisateurService()
        {
            _utilisateurRepository = new UtilisateurRepository();
            _authRepository = new AuthRepository();
        }
        public bool Delete(int id)
        {
            return _utilisateurRepository.Delete(id);

        }
        public IEnumerable<Utilisateur> Get() // projet de la dal client
        {
            return _utilisateurRepository.Get().Select(p => p.ToClient()); // projet de la dal global
        }
        public Utilisateur CheckUser(Utilisateur utilisateur)
        {
            return _authRepository.Login(utilisateur.ToGlobal()).ToClient();
        }

        public bool RegisterUser(Utilisateur utilisateur)
        {
            return _authRepository.Register(utilisateur.ToGlobal()) > 0;
        }

        public Utilisateur Get(int id)
        {
            return _utilisateurRepository.Get(id).ToClient();
        }

        public int Insert(Utilisateur form)
        {
            G.Utilisateur utilisateur = new G.Utilisateur();
            utilisateur.Nom = form.Nom;
            utilisateur.Prenom = form.Prenom;
            utilisateur.AdresseMail = form.AdresseMail;
            utilisateur.Telephone = form.Telephone;
            utilisateur.Roles = form.Roles;

            //utilisateur.AdresseId = form.AdresseId;
            utilisateur.CP = form.CP;
            utilisateur.Num = form.Num;
            utilisateur.Rue = form.Rue;
            utilisateur.Pays = form.Pays;
            utilisateur.Ville = form.Ville;
            utilisateur.CGLatitude = form.CGLatitude;
            utilisateur.CGLongitude = form.CGLongitude;

            return _utilisateurRepository.Insert(utilisateur);

        }
        public int Update(int id, Utilisateur form)
        {
            G.Utilisateur utilisateur = new G.Utilisateur();
            utilisateur.Id = form.Id;
            utilisateur.Nom = form.Nom;
            utilisateur.Prenom = form.Prenom;
            utilisateur.AdresseMail = form.AdresseMail;
            utilisateur.Telephone = form.Telephone;
            utilisateur.Roles = form.Roles;
            utilisateur.AdresseId = form.AdresseId;

            return _utilisateurRepository.Update(id, utilisateur);
        }
    }
}

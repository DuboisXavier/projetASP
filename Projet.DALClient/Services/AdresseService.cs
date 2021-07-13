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
    public class AdresseService : IAdresse<int, C.Adresse>
    {
        private IAdresse<int, G.Adresse> _adresseRepository;

        public AdresseService()
        {
            _adresseRepository = new AdresseRepository();
        }
        public bool Delete(int id)
        {
            return _adresseRepository.Delete(id);

        }

        public IEnumerable<Adresse> Get() // projet de la dal client
        {
            return _adresseRepository.Get().Select(p => p.ToClient()); // projet de la dal global
        }

        public Adresse Get(int id)
        {
            return _adresseRepository.Get(id).ToClient();
        }

        public int Insert(Adresse form)
        {
            G.Adresse adresse = new G.Adresse();
            adresse.CP = form.CP;
            adresse.Num = form.Num;
            adresse.Rue = form.Rue;
            adresse.Pays = form.Pays;
            adresse.Ville = form.Ville;
            adresse.CGLatitude = form.CGLatitude;
            adresse.CGLongitude = form.CGLongitude;

            return _adresseRepository.Insert(adresse);

        }

        public int Update(int id, Adresse form)
        {
            G.Adresse adresse = new G.Adresse();
            adresse.CP = form.CP;
            adresse.Num = form.Num;
            adresse.Rue = form.Rue;
            adresse.Pays = form.Pays;
            adresse.Ville = form.Ville;
            adresse.CGLatitude = form.CGLatitude;
            adresse.CGLongitude = form.CGLongitude;

            return _adresseRepository.Update(id, adresse);
        }


    }


}

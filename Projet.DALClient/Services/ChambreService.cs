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
    public class ChambreService : IChambre<int, C.Chambre>
    {
        private IChambre<int, G.Chambre> _chambreRepository;

        public ChambreService()
        {
            _chambreRepository = new ChambreRepository();
        }
        public bool Delete(int id)
        {
            return _chambreRepository.Delete(id);

        }

        public IEnumerable<Chambre> Get() // projet de la dal client
        {
            return _chambreRepository.Get().Select(p => p.ToClient()); // projet de la dal global
        }
        //public IEnumerable<Chambre> GetByHotel(int id) // projet de la dal client
        //{
        //    return _chambreRepository.Get().Select(p => p.ToClient());// projet de la dal global
        //}

        public Chambre Get(int id)
        {
            return _chambreRepository.Get(id).ToClient();
        }

        public int Insert(Chambre form)
        {
            G.Chambre chambre = new G.Chambre();
            chambre.Numero = form.Numero;
            chambre.DescriptionC = form.DescriptionC;
            chambre.DescriptionL = form.DescriptionL;
            chambre.TypeDeChambre = form.TypeDeChambre;
            chambre.Capacite = form.Capacite;
            chambre.NombreDeSDB = form.NombreDeSDB;
            chambre.NombreDeWC = form.NombreDeWC;
            chambre.Prix = form.Prix;            
            chambre.HotelId = form.HotelId;
            
           
            return _chambreRepository.Insert(chambre);

        }

        public int Update(int id, Chambre form)
        {
            G.Chambre chambre = new G.Chambre();
            chambre.Numero = form.Numero;
            chambre.DescriptionC = form.DescriptionC;
            chambre.DescriptionL = form.DescriptionL;
            chambre.TypeDeChambre = form.TypeDeChambre;
            chambre.Capacite = form.Capacite;
            chambre.NombreDeSDB = form.NombreDeSDB;
            chambre.NombreDeWC = form.NombreDeWC;
            chambre.Prix = form.Prix;
            chambre.HotelId = form.HotelId;

            return _chambreRepository.Update(id, chambre);
        }
    }
}

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
    public class HotelService : IHotel<int, C.Hotel>
    {
        private IHotel<int, G.Hotel> _hotelRepository;

        public HotelService()
        {
            _hotelRepository = new HotelRepository();
        }
        public bool Delete(int id)
        {
            return _hotelRepository.Delete(id);

        }
        
        public IEnumerable<Hotel> Get() // projet de la dal client
        {
            return _hotelRepository.Get().Select(p => p.ToClient()); // projet de la dal global
        }

        public Hotel Get(int id)
        {
            return _hotelRepository.Get(id).ToClient();
        }

        public int Insert(Hotel form)
        {
            G.Hotel hotel = new G.Hotel();
            hotel.Nom = form.Nom;
            hotel.NombreEtoile = form.NombreEtoile;
            hotel.Telephone = form.Telephone;
            hotel.Email = form.Email;
            hotel.NombreChambre = form.NombreChambre;
            //hotel.AdresseId = form.AdresseId;
            hotel.CP = form.CP;
            hotel.Num = form.Num;
            hotel.Rue = form.Rue;
            hotel.Pays = form.Pays;
            hotel.Ville = form.Ville;
            hotel.CGLatitude = form.CGLatitude;
            hotel.CGLongitude = form.CGLongitude;

            return _hotelRepository.Insert(hotel);
            
        }

        public int Update(int id, Hotel form)
        {
            G.Hotel hotel = new G.Hotel();
            hotel.Nom = form.Nom;
            hotel.NombreEtoile = form.NombreEtoile;
            hotel.Telephone = form.Telephone;
            hotel.Email = form.Email;
            hotel.NombreChambre = form.NombreChambre;
            hotel.AdresseId = form.AdresseId;

            return _hotelRepository.Update(id, hotel);
        }
    }
}

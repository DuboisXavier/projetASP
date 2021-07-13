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
    public class PhotosService : IPhotos<int, C.Photos>
    {
        private IPhotos<int, G.Photos> _photosRepository;

        public PhotosService()
        {
            _photosRepository = new PhotosRepository();
        }
        public bool Delete(int id)
        {
            return _photosRepository.Delete(id);

        }

        public IEnumerable<Photos> Get() // projet de la dal client
        {
            return _photosRepository.Get().Select(p => p.ToClient()); // projet de la dal global
        }

        public Photos Get(int id)
        {
            return _photosRepository.Get(id).ToClient();
        }

        public int Insert(Photos form)
        {
            G.Photos photos = new G.Photos();
            photos.Photo = form.Photo;
            photos.HotelId = form.HotelId;
            photos.ChambreId = form.ChambreId;
            

            return _photosRepository.Insert(photos);

        }

        public int Update(int id, Photos form)
        {
            G.Photos photos = new G.Photos();
            photos.Photo = form.Photo;
            photos.HotelId = form.HotelId;
            photos.ChambreId = form.ChambreId;

            return _photosRepository.Update(id, photos);
        }
    }
}

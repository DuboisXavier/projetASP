using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using A = ProjetASP.API.Models;
using C = Projet.DALClient.Models;

namespace ProjetASP.API.Mapper
{
    public static class PhotosMapper
    {
        public static C.Photos ToClient(this A.Photos entity)
        {
            if (entity == null) return null;
            return new C.Photos
            {
                Id = entity.Id,
                Photo = entity.Photo,
                HotelId = entity.HotelId,
                ChambreId = entity.ChambreId


            };
        }
        public static A.Photos ToAPI(this C.Photos entity)
        {
            if (entity == null) return null;
            return new A.Photos(entity);
        }
    }
}
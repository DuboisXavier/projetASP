
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using A = ProjetASP.API.Models;
using C = Projet.DALClient.Models;


namespace ProjetASP.API.Mapper
{
    public static class RoleMapper
    {
        public static C.Role ToClient(this A.Role entity)
        {
            if (entity == null) return null;
            return new C.Role
            {
                Id = entity.Id,
                Nom = entity.Nom               
            };
        }
        public static A.Role ToAPI(this C.Role entity)
        {
            if (entity == null) return null;
            return new A.Role(entity);
        }
    }
}
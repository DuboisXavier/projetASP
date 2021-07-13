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
    public class RoleService : IRole<int, C.Role>
    {
        private IRole<int, G.Role> _roleRepository;

        public RoleService()
        {
            _roleRepository = new RoleRepository();
        }
        public bool Delete(int id)
        {
            return _roleRepository.Delete(id);

        }

        public IEnumerable<Role> Get() // projet de la dal client
        {
            return _roleRepository.Get().Select(p => p.ToClient()); // projet de la dal global
        }

        public Role Get(int id)
        {
            return _roleRepository.Get(id).ToClient();
        }

        public int Insert(Role form)
        {
            G.Role role = new G.Role();
            role.Nom = form.Nom;
            
            return _roleRepository.Insert(role);

        }

        public int Update(int id, Role form)
        {
            G.Role role = new G.Role();
            role.Nom = form.Nom;
           
            return _roleRepository.Update(id, role);
        }
    }
}

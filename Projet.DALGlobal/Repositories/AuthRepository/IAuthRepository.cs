using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet.DALGlobal.Repositories.AuthRepository
{
    public interface IAuthRepository<TId, TEntity>
    {
        TId Register(TEntity form);
        TEntity Login(TEntity form);
    }
}

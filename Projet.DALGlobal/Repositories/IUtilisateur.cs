using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet.DALGlobal.Repositories
{
    public interface IUtilisateur<TId, TEntity> : IRepository<TId, TEntity>
    {
    }
}

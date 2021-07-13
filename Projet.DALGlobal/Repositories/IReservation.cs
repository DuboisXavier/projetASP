using Projet.DALGlobal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet.DALGlobal.Repositories
{
    public interface IReservation<TId, TEntity> : IRepository<TId, TEntity>
    {
        IEnumerable<Reservation> GetByUser(int id);
    }
}

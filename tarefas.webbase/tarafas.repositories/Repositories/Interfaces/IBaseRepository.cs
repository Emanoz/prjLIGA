using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tarafas.repositories.Repositories.Interfaces
{
    public interface IBaseRepository<TEntity>
    {
        Task Create(TEntity entity);
        Task Update(TEntity entity);
        Task Delete(TEntity entity);
        Task<List<TEntity>> GetAll();
    }
}

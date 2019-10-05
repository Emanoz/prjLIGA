using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tarefas.data.Models.Entities;

namespace tarafas.repositories.Repositories.Interfaces
{
    public interface IUserRepository : IBaseRepository<UserEntity>
    {
        Task<UserEntity> GetByUsernameAsync(string username);
        Task<bool> HasUsername(string username);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using tarafas.repositories.Repositories.Interfaces;
using tarafas.repositories.Repositories.Sql.Base;
using tarefas.data.Context;
using tarefas.data.Models.Entities;

namespace tarafas.repositories.Repositories.Sql
{
    public class UserRepository : BaseRepository<SqlContext, UserEntity>, IUserRepository
    {
        public UserRepository(SqlContext context) : base(context, context.Users)
        {
        }

        public async Task<UserEntity> GetByUsernameAsync(string username)
        {
            var user = await DbSet.FirstOrDefaultAsync(f => f.Active && f.Username == username);
            return user;
        }

        public async Task<bool> HasUsername(string username) => await DbSet.AnyAsync(a => a.Username == username);
    }
}

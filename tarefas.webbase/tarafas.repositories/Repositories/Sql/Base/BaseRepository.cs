using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tarafas.repositories.Repositories.Interfaces;

namespace tarafas.repositories.Repositories.Sql.Base
{
    public abstract class BaseRepository<TContext, TEntity> : IBaseRepository<TEntity> where TContext : DbContext where TEntity : class
    {
        protected DbSet<TEntity> DbSet { get; set; }
        protected TContext Context { get; set; }

        public BaseRepository(TContext context, DbSet<TEntity> dbSet)
        {
            DbSet = dbSet;
            Context = context;
        }

        public async Task Create(TEntity entity)
        {
            await DbSet.AddAsync(entity);
            await Context.SaveChangesAsync();
        }

        public async Task Delete(TEntity entity)
        {
            DbSet.Remove(entity);
            await Context.SaveChangesAsync();
        }

        public async Task<List<TEntity>> GetAll()
        {
            return await DbSet.ToListAsync();
        }

        public async Task Update(TEntity entity)
        {
            DbSet.Update(entity);
            await Context.SaveChangesAsync();

        }
    }
}

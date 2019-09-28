using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tarefas.data.Models.Entities;

namespace tarefas.data.Context
{
    public class SqlContext : DbContext
    {
        public SqlContext()
        {

        }

        public SqlContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<UserEntity> Users { get; set; }
        public DbSet<TaskEntity> Tasks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TaskEntity>().HasOne<UserEntity>(options => options.User).WithMany(opt => opt.Tasks);
            base.OnModelCreating(modelBuilder);
        }
    }
}

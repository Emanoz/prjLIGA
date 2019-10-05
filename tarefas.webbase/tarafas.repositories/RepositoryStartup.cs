using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tarafas.repositories.Repositories.Interfaces;
using tarafas.repositories.Repositories.Sql;

namespace tarafas.repositories
{
    public static class RepositoryStartup
    {
        public static void AddServices(IServiceCollection service)
        {
            service.AddScoped<IUserRepository, UserRepository>();
        }
    }
}

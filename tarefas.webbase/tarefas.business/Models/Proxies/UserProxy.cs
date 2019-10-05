using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tarefas.business.Models.Proxies.Base;
using tarefas.data.Models.Entities;

namespace tarefas.business.Models.Proxies
{
    public class UserProxy : BaseProxyEntity<UserEntity, UserProxy>
    {
        public string Name { get; set; }
        public string Username { get; set; }

        public override UserProxy EntityToProxy(UserEntity entity)
        {
            var proxy = base.EntityToProxy(entity);
            proxy.Name = entity.Name;
            proxy.Username = entity.Username;
            return proxy;
        }
    }
}

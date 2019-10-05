using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tarefas.data.Models.Entities.Base;

namespace tarefas.business.Models.Proxies.Base
{
    public abstract class BaseProxyEntity<TEntity, TProxy> where TProxy : BaseProxyEntity<TEntity, TProxy>, new() where TEntity : BaseEntity
    {
        public int Id { get; set; }
        public bool Active { get; set; }

        public virtual TProxy EntityToProxy(TEntity entity)
        {
            var proxy = new TProxy();
            proxy.Id = entity.Id;
            proxy.Active = entity.Active;
            return proxy;
        }

        public List<TProxy> EntityToProxyList(List<TEntity> entityList)
        {
            var proxyList = new List<TProxy>();

            foreach(var entity in entityList)
            {
                proxyList.Add(new TProxy().EntityToProxy(entity));
            }

            return proxyList;
        }
    }
}

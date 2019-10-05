using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tarefas.data.Models.Entities.Base;

namespace tarefas.business.Models.Payloads.Base
{
    public abstract class BasePayloadEntity<TEntity, TPayload> where TEntity : BaseEntity, new() where TPayload: BasePayloadEntity<TEntity, TPayload>
    {
        public bool Active { get; set; }
        
        public virtual TEntity PayloadToEntity(TPayload payload)
        {
            var entity = new TEntity();

            entity.Active = payload.Active;
            return entity;
        }
    }
}

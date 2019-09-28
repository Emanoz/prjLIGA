using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using tarefas.data.Models.Entities.Base;

namespace tarefas.data.Models.Entities
{
    public class UserEntity : BaseEntity
    {
        public string Name { get; set; }
        public string Username { get; set; }
        public string  Password { get; set; }
        public string Roles { get; set; }
        public virtual ICollection<TaskEntity> Tasks { get; set; }
    }
}

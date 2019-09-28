using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using tarefas.data.Models.Entities.Base;
using tarefas.webbase.Enums;

namespace tarefas.data.Models.Entities
{
    public class TaskEntity : BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public TaskStatusEnum Status { get; set; }
        public int UserId { get; set; }
        [ForeignKey("UserId")]
        public UserEntity User { get; set; }
    }
}

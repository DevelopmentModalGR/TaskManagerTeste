using System;
using System.Collections.Generic;
using System.Text;
using TaskManagerCore2.Domain.Enums;

namespace TaskManagerCore2.Domain.Entities
{
    public class Jobs : Entity
    {
        public string Name { get; set; }
        public ETaskStatus PredecessorTaskStatus { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public ETaskStatus Status { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}

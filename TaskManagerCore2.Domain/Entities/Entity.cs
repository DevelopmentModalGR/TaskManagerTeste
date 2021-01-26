using System;
using System.Collections.Generic;
using System.Text;

namespace TaskManagerCore2.Domain.Entities
{
    public abstract class Entity
    {
        protected Entity()
        {
            this.Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace TaskManagerCore2.Domain.Entities
{
    public class Department
    {
        public string Name { get; set; }
        public virtual ICollection<CheckoutProcess> CheckoutProcesses { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}

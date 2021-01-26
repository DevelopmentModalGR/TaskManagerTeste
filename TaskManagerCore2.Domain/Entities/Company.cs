using System;
using System.Collections.Generic;
using System.Text;

namespace TaskManagerCore2.Domain.Entities
{
    public class Company
    {
        public string Name { get; set; }
        public string CNPJ { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}

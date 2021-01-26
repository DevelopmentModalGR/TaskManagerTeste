using System;
using System.Collections.Generic;
using System.Text;

namespace TaskManagerCore2.Domain.Entities
{
    public class CheckoutProcess
    {
        public string Name { get; set; }
        public Department Department { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public virtual ICollection<Jobs> Jobs { get; set; }
    }
}

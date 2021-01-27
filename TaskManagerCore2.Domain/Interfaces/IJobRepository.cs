using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TaskManagerCore2.Domain.Entities;

namespace TaskManagerCore2.Domain.Interfaces
{
    public interface IJobRepository : IRepository<Jobs>
    {
        Task GetJobByTagName();
    }
}

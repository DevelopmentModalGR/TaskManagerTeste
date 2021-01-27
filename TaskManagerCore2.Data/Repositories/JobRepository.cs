using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TaskManagerCore2.Data.Context;
using TaskManagerCore2.Domain.Entities;
using TaskManagerCore2.Domain.Interfaces;

namespace TaskManagerCore2.Data.Repositories
{
    public class JobRepository : Repository<Jobs>, IJobRepository
    {
        public JobRepository(DataContext context) : base(context)
        {

        }

        public Task GetJobByTagName()
        {
            throw new NotImplementedException();
        }
    }
}

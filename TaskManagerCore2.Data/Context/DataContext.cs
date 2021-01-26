using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TaskManagerCore2.Domain.Entities;

namespace TaskManagerCore2.Data.Context
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {         
        
        }

        public DbSet<CheckoutProcess> CheckoutProcesses { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Jobs> Jobs { get; set; }
        public DbSet<User> User { get; set; }
    }
}

using CrudVirtusa.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CrudVirtusa.Database
{
    public class EmployeeDbContext : DbContext
    {
        public EmployeeDbContext() : base("TestDbEntities")
        {}

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Customer> Customers { get; set; }

    }
}
using SoftwareManagement.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareManagement.Database
{
    class ModelContext : DbContext
    {
        public ModelContext() : base("name=BakeryDB") { }

        public DbSet<Employee> EmployeeList { get; set; }
        public DbSet<Product> ProductList { get; set; }
        public DbSet<Contractor> ContractorList { get; set; }
        public DbSet<Address> AddressList { get; set; }
        public DbSet<User> UserList { get; set; }
        public DbSet<ProductType> ProductTypeList { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasKey(x => x.ProductID);
            modelBuilder.Entity<Employee>().HasKey(x => x.EmpID);

        }

    }
}

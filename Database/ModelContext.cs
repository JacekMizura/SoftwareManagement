using SoftwareManagement.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
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
        public DbSet<Ingredient> IngredientList { get; set; }
        public DbSet<Contractor> ContractorList { get; set; }

        public DbSet<Address> AddressList { get; set; }
        public DbSet<CategoryType> CategoryTypeList { get; set; }
        public DbSet<User> UserList { get; set; }


    }
}

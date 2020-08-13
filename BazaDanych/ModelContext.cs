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
        public ModelContext() : base("name=BakeryDB")
        {
            this.Configuration.ProxyCreationEnabled = false;
        }

        public DbSet<Pracownik> Pracownicy { get; set; }
        public DbSet<Produkt> Produkty { get; set; }
        public DbSet<Kontrahent> Kontrahenci { get; set; }
        public DbSet<Adres> Adresy { get; set; }
        public DbSet<Uzytkownik> Uzytkownicy { get; set; }
        public DbSet<RodzajProduktu> RodzajeProduktow { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Entity<Pracownik>().HasKey(x => x.PracownikID);

            modelBuilder.Entity<Kontrahent>()
                .HasOptional(a => a.Adres)
                .WithRequired(c => c.Kontrahent)
                .WillCascadeOnDelete(true);

        }

    }
}

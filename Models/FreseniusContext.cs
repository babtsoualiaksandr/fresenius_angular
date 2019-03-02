using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Fresenius_Angular.Models
{
public class FreseniusContext : DbContext
    {
        public DbSet<Country> Countries { get; set; }
        public DbSet<Equipment> Equipments { get; set; }
        public DbSet<IdentityCard> IdentityCards { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<Manufacturer> Manufacturers { get; set; }
        public DbSet<ProductNames> ProductNames { get; set; }
        public DbSet<Sparepart> Spareparts { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseNpgsql("Host=localhost;Database=fresenius_angular;Username=postgres;Password=root");
    }
}
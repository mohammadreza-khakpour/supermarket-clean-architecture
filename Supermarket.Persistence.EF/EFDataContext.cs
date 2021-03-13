using Microsoft.EntityFrameworkCore;
using Supermarket.Entities;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Supermarket.Persistence.EF
{
    public class EFDataContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=.;database=architectureTest123;trusted_connection=true");
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Good> Goods { get; set; }
        public DbSet<GoodCategory> GoodCategories { get; set; }
    }
}

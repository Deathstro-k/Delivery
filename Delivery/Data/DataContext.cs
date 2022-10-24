using Delivery.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Delivery.Data
{
    public sealed class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        public DbSet<FruitProvider> FruitProviders { get; set; }      
        public DbSet<ProductCategory> ProductCategories { get; set; }       
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }       
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
              
            modelBuilder.Entity<Order>().Property(p => p.RegistrationDate).HasDefaultValue(DateTime.Now);
            modelBuilder.Entity<Order>().Property(p => p.EndDate)
                .HasComputedColumnSql("DATEADD(month,[DeliveryTime],[RegistrationDate])", stored: true);
            modelBuilder.Entity<Order>().Property(p => p.TotalPrice);
            modelBuilder.Entity<Order>().Property(p => p.TotalWeight);


        }

    }
}

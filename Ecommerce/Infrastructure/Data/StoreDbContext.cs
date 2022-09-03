using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Collections.Generic;
using System.Reflection;

namespace Infrastructure.Data
{
    public class StoreDbContext : DbContext
    {
        public StoreDbContext(DbContextOptions<StoreDbContext> options) : base(options)
        {

        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Product>().Property(p => p.Id).IsRequired();
            //modelBuilder.Entity<Product>().Property(p => p.Name).IsRequired().HasMaxLength(100);
            //modelBuilder.Entity<Product>().Property(p => p.Description).IsRequired().HasMaxLength(180);
            //modelBuilder.Entity<Product>().Property(p => p.Price).HasColumnType("decimal(18,2)");

                
            //modelBuilder.Entity<Product>().HasData();
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new ProductConfiguration());

        }
        
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductBrand> ProductBrands { get; set; }
        public DbSet<ProductType> ProductTypes { get; set; }
    }
}

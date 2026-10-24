using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using UTB.Eshop26K.Domain.Entities;
using UTB.Eshop26K.Infrastructure.Database.Seeding;

namespace UTB.Eshop26K.Infrastructure.Database
{
    public class EshopDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        public EshopDbContext(DbContextOptions<EshopDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed data for Products
            var productInit = new ProductInit();
            var products = productInit.GetProductsFood3();
            modelBuilder.Entity<Product>().HasData(products);
        }
    }
}

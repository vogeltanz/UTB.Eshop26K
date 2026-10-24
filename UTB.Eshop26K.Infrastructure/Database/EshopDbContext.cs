using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using UTB.Eshop26K.Domain.Entities;

namespace UTB.Eshop26K.Infrastructure.Database
{
    public class EshopDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        public EshopDbContext(DbContextOptions<EshopDbContext> options) : base(options)
        {
        }
    }
}

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using UTB.Eshop26K.Domain.Entities;
using UTB.Eshop26K.Domain.Repositories;
using UTB.Eshop26K.Infrastructure.Database;

namespace UTB.Eshop26K.Infrastructure.Repositories
{
    public class ProductRepository : Repository<Product, int>, IProductRepository
    {
        public ProductRepository(EshopDbContext dbContext) : base(dbContext)
        {
        }
    }
}

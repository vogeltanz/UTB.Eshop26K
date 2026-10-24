using System;
using System.Collections.Generic;
using System.Text;
using UTB.Eshop26K.Domain.Entities;

namespace UTB.Eshop26K.Domain.Repositories
{
    public interface IProductRepository : IRepository<Product, int>
    {
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using UTB.Eshop26K.Domain.Entities;

namespace UTB.Eshop26K.Application.Abstraction
{
    public interface IProductAppService
    {
        IList<Product> SelectAll();
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using UTB.Eshop26K.Application.Abstraction;
using UTB.Eshop26K.Domain.Entities;
using UTB.Eshop26K.Domain.Repositories;

namespace UTB.Eshop26K.Application.Implementation
{
    public class ProductAppService : IProductAppService
    {
        private readonly IProductRepository _productRepository;

        public ProductAppService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public IList<Product> SelectAll()
        {
            return _productRepository.GetAll().ToList();
        }

        public void Create(Product product)
        {
            _productRepository.Add(product);
        }

        public bool Delete(int id)
        {
            var product = _productRepository.GetById(id);

            if (product != null)
            {
                _productRepository.Delete(product);
                return true;
            }

            return false;
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using Moq;
using UTB.Eshop26K.Application.Abstraction;
using UTB.Eshop26K.Domain.Entities;
using UTB.Eshop26K.Web.Areas.Admin.Controllers;

namespace UTB.Eshop26K.Tests
{
    public class ProductControllerCreateTests
    {
        [Fact]
        public void CreateProduct_PositiveInputs()
        {
            // Arrange
            List<Product> products = new List<Product>();
            Mock<IProductAppService> mockProductAppService = new Mock<IProductAppService>();
            mockProductAppService.Setup(productAppService => productAppService.Create(It.IsAny<Product>()))
                                                                                .Callback<Product>(product => { products.Add(product); return; });

            ProductController productController = new ProductController(mockProductAppService.Object);

            Product product = new Product
            {
                Name = "Test Product",
                Description = "Test Description",
                Price = 10.0,
                ImageUrl = "test.jpg"
            };

            // Act
            IActionResult result = productController.Create(product);

            // Assert
            Assert.Contains(product, products);
            Assert.Single(products);
            Assert.IsType<RedirectToActionResult>(result);
        }

        [Fact]
        public void CreateProduct_NegativeInputs()
        {
            // Arrange
            List<Product> products = new List<Product>();
            Mock<IProductAppService> mockProductAppService = new Mock<IProductAppService>();
            mockProductAppService.Setup(productAppService => productAppService.Create(It.IsAny<Product>()))
                                                                                .Callback<Product>(product => { products.Add(product); return; });

            ProductController productController = new ProductController(mockProductAppService.Object);

            Product product = new Product
            {
                Name = null!,
                Description = "Test Description",
                Price = 10.0,
                ImageUrl = "test.jpg"
            };

            productController.ModelState.AddModelError(nameof(Product.Name), "The Name field is required.");

            // Act
            IActionResult result = productController.Create(product);

            // Assert
            Assert.Empty(products);
            Assert.IsType<ViewResult>(result);
        }
    }
}

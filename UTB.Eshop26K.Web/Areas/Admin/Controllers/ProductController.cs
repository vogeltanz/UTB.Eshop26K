using Microsoft.AspNetCore.Mvc;
using UTB.Eshop26K.Application.Abstraction;
using UTB.Eshop26K.Domain.Entities;

namespace UTB.Eshop26K.Web.Areas.Admin.Controllers
{
    [Area(nameof(Admin))]
    public class ProductController : Controller
    {
        readonly IProductAppService _productAppService;

        public ProductController(IProductAppService productAppService)
        {
            _productAppService = productAppService;
        }

        public IActionResult Select()
        {
            var products = _productAppService.SelectAll();
            return View(products);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Product product)
        {
            _productAppService.Create(product);
            return RedirectToAction(nameof(Select));
        }

        public IActionResult Delete(int id)
        {
            var success = _productAppService.Delete(id);
            if (success)
            {
                return RedirectToAction(nameof(Select));
            }
            return NotFound();
        }
    }
}

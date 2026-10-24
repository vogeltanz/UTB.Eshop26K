using Microsoft.AspNetCore.Mvc;
using UTB.Eshop26K.Application.Abstraction;

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
    }
}

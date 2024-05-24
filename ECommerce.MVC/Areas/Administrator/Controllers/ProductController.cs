using ECommerce.BLL.Services.Abstracts;
using ECommerce.BLL.ViewModels.ProductViewModels;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.MVC.Areas.Administrator.Controllers
{
    [Area("Administrator")]
    public class ProductController : Controller
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
        public IActionResult Index()
        {
            var products = _productService.GetAllProducts()
                .OrderByDescending(x => x.CreatedDate)
                .Select(x => new ProductViewModelAdmin{
                Id=x.ID,
                ProductName =x.ProductName,
                UnitPrice = x.UnitPrice,
                UnitsInStock = x.UnitsInStock,
                IsActive = x.IsActive,
                Status = x.Status,
            }).ToList();
            return View(products);
        }
    }
}

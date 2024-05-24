using ECommerce.BLL.Services.Abstracts;
using ECommerce.BLL.ViewModels.ProductViewModels;
using ECommerce.Models.Entities;
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

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(ProductViewModelUser productVM)
        {
            if (ModelState.IsValid)
            {
                Product product = new Product()
                {
                    ProductName = productVM.ProductName,
                    UnitPrice = productVM.UnitPrice,
                    UnitsInStock= productVM.UnitsInStock,
                    SupplierId = productVM.SupplierId,
                    CategoryId = productVM.CategoryId,
                    ImagePath = productVM.ImagePath,
                };
                string result = await _productService.AddProductAsync(product);
                ViewData["Result"] = result;

                return RedirectToAction("Index", "Product");
            }
            else
            {
                return View();
            }
        }
    }
}

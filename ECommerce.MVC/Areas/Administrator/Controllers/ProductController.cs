using ECommerce.BLL.Services.Abstracts;
using ECommerce.BLL.Services.Concretes;
using ECommerce.BLL.ViewModels.CategoryViewModels;
using ECommerce.BLL.ViewModels.ProductViewModels;
using ECommerce.Models.Entities;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.MVC.Areas.Administrator.Controllers
{
    [Area("Administrator")]
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;
        private readonly ISupplierService _supplierService;

        public ProductController(IProductService productService, ICategoryService categoryService, ISupplierService supplierService)
        {
            _productService = productService;
            _categoryService = categoryService;
            _supplierService = supplierService;
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
                    Category = _categoryService.GetCategoryById(productVM.CategoryId),
                    Supplier = _supplierService.GetSupplierById(productVM.SupplierId),
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

        [HttpGet]

        public IActionResult Update(int id)
        {
            var updated = _productService.GetProductById(id);

            
            if (updated != null)
            {
                return View(updated);
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }

        }

        [HttpPost]
        public async Task<IActionResult> Update(Product product)
        {
            product.Category = _categoryService.GetCategoryById(product.CategoryId);
            product.Supplier = _supplierService.GetSupplierById(product.SupplierId);

            string result = await _productService.UpdateProductAsync(product);

            TempData["result"] = result;

            return RedirectToAction("Index", "Product");

        }

        public IActionResult Active()
        {
            var products = _productService.GetActiveProducts()
                .OrderByDescending(x => x.CreatedDate)
                .Select(x => new ProductViewModelAdmin
                {
                    Id = x.ID,
                    ProductName = x.ProductName,
                    UnitPrice = x.UnitPrice,
                    UnitsInStock = x.UnitsInStock,
                    IsActive = x.IsActive,
                    Status = x.Status,
                }).ToList();
            return View(products);
        }

        public IActionResult Passive()
        {
            var products = _productService.GetPassiveProducts()
                .OrderByDescending(x => x.CreatedDate)
                .Select(x => new ProductViewModelAdmin
                {
                    Id = x.ID,
                    ProductName = x.ProductName,
                    UnitPrice = x.UnitPrice,
                    UnitsInStock = x.UnitsInStock,
                    IsActive = x.IsActive,
                    Status = x.Status,
                }).ToList();
            return View(products);
        }
    }
}

﻿using ECommerce.BLL.Services.Abstracts;
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

        //Product Home (List All Products)
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

        //Get: Create Product
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        //Post: Create Product
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

        //Get: Update Product
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

        //Post: Update Product
        [HttpPost]
        public async Task<IActionResult> Update(Product product)
        {
            if (!ModelState.IsValid)
            {
                return View(product);
            }
            product.Category = _categoryService.GetCategoryById(product.CategoryId);
            product.Supplier = _supplierService.GetSupplierById(product.SupplierId);

            string result = await _productService.UpdateProductAsync(product);

            TempData["result"] = result;

            return RedirectToAction("Index", "Product");

        }

        //List Active Products
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

        //List Passive Product
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

        //Get: Delete data from database (Destroy Data)
        [HttpGet]
        public IActionResult Destroy(int id)
        {
            var deleted = _productService.GetProductById(id);

            if (deleted != null)
            {
                return View(deleted);
            }

            return RedirectToAction("Index", "Home");
        }
        //Post: Delete data from database (Destroy Data)
        [HttpPost]
        public async Task<IActionResult> Destroy(Product product)
        {
            if (product != null)
            {
                string result = await _productService.DestroyProductAsync(product);

                TempData["Result"] = result;

                return RedirectToAction("Index", "Product");
            }

            return View(product);
        }
    }
}

using ECommerce.BLL.Services.Abstracts;
using ECommerce.BLL.ViewModels.CategoryViewModels;
using ECommerce.BLL.ViewModels.ProductViewModels;
using ECommerce.Models.Entities;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.MVC.Areas.Administrator.Controllers
{
    [Area("Administrator")]
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;
        private readonly IProductService _productService;

        public CategoryController(ICategoryService categoryService, IProductService productService)
        {
            _categoryService = categoryService;
            _productService = productService;
        }

        //Category Home (List All Categories)
        public IActionResult Index()
        {
            var categories = _categoryService
                .GetAllCategories()
                .OrderByDescending(x => x.CreatedDate)
                .Select(x => new CategoryViewModelAdmin
                {
                    Id = x.ID,
                    CategoryName = x.CategoryName,
                    Description = x.Description,
                    IsActive = x.IsActive,
                    Status = x.Status
                }).ToList();
            return View(categories);
        }

        //Get: Create Category
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        //Post: Create Category
        [HttpPost]
        public async Task<IActionResult> Create(CategoryViewModelUser categoryVM)
        {
            if (ModelState.IsValid)
            {
                Category category = new Category()
                {
                    CategoryName = categoryVM.CategoryName,
                    Description = categoryVM.Description,
                };

                string result = await _categoryService.AddCategoryAsync(category);
                TempData["Result"] = result;
                return RedirectToAction("Index", "Category");

            }
            else
            {
                return View(categoryVM);
            }

        }

        //Get: Update Category
        [HttpGet]
        public IActionResult Update(int id)
        {
            var updated = _categoryService.GetCategoryById(id);
            
            if (updated != null)
            {
                return View(updated);
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }

        }

        //Post: Update Category
        [HttpPost]
        public async Task<IActionResult> Update(Category category)
        {
            if (!ModelState.IsValid)
            {
                return View(category);
            }

            string result = await _categoryService.UpdateCategoryAsync(category);

            TempData["result"] = result;

            return RedirectToAction("Index", "Category");

        }

        //List Active Categories
        public IActionResult Active()
        {
            var categories = _categoryService
                .GetActiveCategories()
                .OrderByDescending(x => x.CreatedDate)
                .Select(x => new CategoryViewModelAdmin
                {
                    Id = x.ID,
                    CategoryName = x.CategoryName,
                    Description = x.Description,
                    IsActive = x.IsActive,
                    Status = x.Status
                }).ToList();
            return View(categories);
        }

        //List Passive Categories
        public IActionResult Passive()
        {
            var categories = _categoryService
                .GetPassiveCategories()
                .OrderByDescending(x => x.CreatedDate)
                .Select(x => new CategoryViewModelAdmin
                {
                    Id = x.ID,
                    CategoryName = x.CategoryName,
                    Description = x.Description,
                    IsActive = x.IsActive,
                    Status = x.Status
                }).ToList();
            return View(categories);
        }
        //Get: Delete data from database (Destroy Data)
        [HttpGet]
        public IActionResult Destroy(int id)
        {
            var deleted = _categoryService.GetCategoryById(id);

            if (deleted != null)
            {
                return View(deleted);
            }
            
            return RedirectToAction("Index", "Home");
        }

        //Post: Delete data from database (Destroy Data)
        [HttpPost]
        public async Task<IActionResult> Destroy (Category category)
        {
            if (category != null)
            {
                string result = await _categoryService.DestroyCategoryAsync(category);

                TempData["Result"] = result;

                return RedirectToAction("Index", "Category");
            }
            
            return View(category);
        }

        public IActionResult Details(int id)
        {
            var category = _categoryService.GetCategoryById(id);
            var products = new List<ProductViewModelAdmin>();

            products = category.Products.Where(x=>x.CategoryId==id).Select(x => new ProductViewModelAdmin(){
            Id = x.ID,
            UnitPrice = x.UnitPrice,
            UnitsInStock = x.UnitsInStock,
            ImagePath = x.ImagePath,
            Status = x.Status,
            IsActive = x.IsActive,
            
            }).ToList();

            return View(products);
        }
    }
}

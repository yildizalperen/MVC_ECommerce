using ECommerce.BLL.Services.Abstracts;
using ECommerce.BLL.ViewModels.CategoryViewModels;
using ECommerce.Models.Entities;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.MVC.Areas.Administrator.Controllers
{
    [Area("Administrator")]
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

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

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

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
                return RedirectToAction("Index","Category");

            }
            else
            {
                return View(categoryVM);
            }
            
        }
    }
}

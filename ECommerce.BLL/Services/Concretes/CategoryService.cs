using ECommerce.BLL.Repositories.Abstracts;
using ECommerce.BLL.Services.Abstracts;
using ECommerce.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.BLL.Services.Concretes
{
    public class CategoryService : ICategoryService
    {

        private readonly IBaseService<Category> _categoryRepository;

        public CategoryService(IBaseService<Category> categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public async Task<string> AddCategoryAsync(Category category)
        {
            return await _categoryRepository.Add(category);
        }

        public async Task<string> DeleteCategoryAsync(Category category)
        {
            return await _categoryRepository.Delete(category);
        }

        public async Task<string> DestroyCategoryAsync(Category category)
        {
            return await _categoryRepository.DestroyData(category);
        }

        public IEnumerable<Category> GetActiveCategories()
        {
            return _categoryRepository.GetActives();
        }

        public IEnumerable<Category> GetAllCategories()
        {
            return _categoryRepository.GetAll();
        }

        public Category GetCategoryById(int id)
        {
            return _categoryRepository.GetById(id);
        }

        public IEnumerable<Category> GetPassiveCategories()
        {
            return _categoryRepository.GetPassives();
        }

        public async Task<string> UpdateCategoryAsync(Category category)
        {
            return await _categoryRepository.Update(category);
        }
    }
}

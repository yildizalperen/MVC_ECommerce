using ECommerce.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.BLL.Services.Abstracts
{
    public interface ICategoryService 
    {
        IEnumerable<Category> GetAllCategories();
        Category GetCategoryById(int id);
        Task<string> AddCategoryAsync(Category category);
        Task<string> DeleteCategoryAsync(Category category);
        Task<string> UpdateCategoryAsync(Category category);
        IEnumerable<Category> GetActiveCategories();
        IEnumerable<Category> GetPassiveCategories();
        Task<string> DestroyCategoryAsync(Category category);
    }
}

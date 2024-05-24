using ECommerce.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.BLL.ViewModels.CategoryViewModels
{
    public class CategoryViewModelAdmin
    {
        public int Id { get; set; }
        [Display(Name = "Kategori Adı")]
        public string CategoryName { get; set; }
        [Display(Name = "Kategori Açıklaması")]
        public string Description { get; set; }
        [Display(Name = "Kategori Durumu")]
        public DataStatus Status { get; set; }
        [Display(Name = "Kategori Aktifliği")]
        public bool IsActive { get; set; }

    }
}

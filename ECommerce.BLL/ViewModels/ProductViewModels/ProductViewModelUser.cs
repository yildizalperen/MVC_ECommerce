using ECommerce.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.BLL.ViewModels.ProductViewModels
{
    public class ProductViewModelUser
    {
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public short UnitsInStock { get; set; }
        public int SupplierId  { get; set; }
        public int CategoryId { get; set; }
        public string ImagePath { get; set; }

    }
}

using ECommerce.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.BLL.ViewModels.ProductViewModels
{
    public class ProductViewModelAdmin
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public short UnitsInStock { get; set; }
        public DataStatus Status { get; set; }
        public bool IsValid { get; set; }
    }
}

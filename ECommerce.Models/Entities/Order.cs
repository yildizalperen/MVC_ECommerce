using ECommerce.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Models.Entities
{
    public class Order : BaseEntity
    {
        public decimal? Freight { get; set; }
        public string CustomerName { get; set; }
        public string CustomerAddress { get; set; }

        //Mapping
        public List<OrderDetail> OrderDetails { get; set; }
    }
}

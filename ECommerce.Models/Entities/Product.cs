﻿using ECommerce.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Models.Entities
{
    public class Product : BaseEntity
    {
        public string ProductName { get; set; }
        public short UnitsInStock { get; set; }
        public decimal UnitPrice { get; set; }
        public string ImagePath { get; set; }

        //Mapping
        public int CategoryId { get; set; }
        public int SupplierId { get; set; }
        public virtual Category? Category { get; set; } 
        public virtual Supplier? Supplier { get; set; } 
        public virtual List<OrderDetail>? OrderDetails { get; set; }
    }
}

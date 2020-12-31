﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MartinPosso_CodeFirstOnlineShop.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public int Stock { get; set; }

        public int ProductCode { get; set; }
        public int SupplierID { get; set; }
        public virtual Supplier Supplier { get; set; }
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }
        public byte[] Image { get; set; }
        public virtual ICollection<Order> Orders { get; set; }

        public virtual ICollection<Posso> Possos { get; set; }
    }
}
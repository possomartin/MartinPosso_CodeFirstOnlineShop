﻿using System.Collections.Generic;

namespace MartinPosso_CodeFirstOnlineShop.Models
{
    public class Supplier
    {
        public int SupplierID { get; set; }
        public string SupplierName { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
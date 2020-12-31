using System.Collections.Generic;

namespace MartinPosso_CodeFirstOnlineShop.Models
{
    public class Category
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string description { get; set; }
        public virtual ICollection<Product> Products { get; set; }
        
    }
}
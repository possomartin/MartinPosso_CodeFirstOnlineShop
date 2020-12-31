using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MartinPosso_CodeFirstOnlineShop.Models
{
    public class ShopDB : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Person> People { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<User> Users { get; set; }

        public System.Data.Entity.DbSet<MartinPosso_CodeFirstOnlineShop.Models.Posso> Possoes { get; set; }
    }
}
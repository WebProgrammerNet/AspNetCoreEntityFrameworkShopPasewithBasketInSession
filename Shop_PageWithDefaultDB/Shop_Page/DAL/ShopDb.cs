using Microsoft.EntityFrameworkCore;
using Shop_Page.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop_Page.DAL
{
    public class ShopDb : DbContext
    {
        public ShopDb(DbContextOptions<ShopDb> options):base(options)
        {

        }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet <ShopCartItem> ShopCartItems { get; set; }
        public DbSet <OrderDetail> OrderDetails { get; set; }
        public DbSet <Order> Orders { get; set; }

    }
}

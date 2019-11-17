using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Shop_Page.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop_Page.Models
{
    public class ShopCart
    {
        private readonly ShopDb _dbshop;
        public ShopCart(ShopDb shopDb)
        {
            _dbshop = shopDb;
        }

        public string ShopCardId { get; set; }
        public List<ShopCartItem> Listshopcartitems { get; set; }

        public static ShopCart GetCart(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;//I created Session
            var context = services.GetService<ShopDb>();//Get DataBase 
            string shopCardId = session.GetString("ShopId") ?? Guid.NewGuid().ToString();//?? Eger sessionda shopcartId yoxdursa 
            //yeni shopcartId generet edirik.
            session.SetString("ShopId", shopCardId);
            return new ShopCart(context) { ShopCardId = shopCardId };
        }

        public void AddToCard(Car car)
        {
            _dbshop.ShopCartItems.Add(new ShopCartItem
            {
                ShopCardId = ShopCardId,
                car = car,
                price = car.Price,
            
                
            });
            _dbshop.SaveChanges();
        }

        public List<ShopCartItem> GetShopCartItems()
        {
            return _dbshop.ShopCartItems.Where(c =>c.ShopCardId == ShopCardId).Include(i =>i.car).ToList();
        }
    }
}
    
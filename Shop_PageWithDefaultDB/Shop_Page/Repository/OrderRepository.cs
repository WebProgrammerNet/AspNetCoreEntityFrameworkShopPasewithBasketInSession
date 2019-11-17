using Shop_Page.DAL;
using Shop_Page.Interfaces;
using Shop_Page.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop_Page.Repository
{
    public class OrderRepository : IAllorders
    {
        private readonly ShopDb _shopDb;
        private readonly ShopCart _shopCart;
        public OrderRepository(ShopDb shopDb, ShopCart shopCart)
        {
            _shopDb = shopDb;
            _shopCart = shopCart;

        }
        public void CreateOrder(Order order)
        {
            order.OrderTime = DateTime.Now;
            _shopDb.Orders.Add(order);
            var items = _shopCart.Listshopcartitems;
            foreach (var item in items)
            {
                var orderDetail = new OrderDetail() {
                    CarId = item.car.Id,
                    OrderId = order.Id,
                    Price = item.car.Price
                };
                _shopDb.OrderDetails.Add(orderDetail);
            }
            _shopDb.SaveChanges();
        }
    }
}
 
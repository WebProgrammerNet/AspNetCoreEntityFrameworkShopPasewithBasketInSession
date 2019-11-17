using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop_Page.Models
{
    public class ShopCartItem
    {
        public int Id { get; set; }
        public Car car { get; set; }
        public double price { get; set; }
        public string ShopCardId { get; set; }
    }
}

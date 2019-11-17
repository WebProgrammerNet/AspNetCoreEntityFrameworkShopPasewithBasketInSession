using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Shop_Page.DAL;
using Shop_Page.Interfaces;
using Shop_Page.Models;

namespace Shop_Page.Controllers
{
    public class OrderController : Controller
    {

        private readonly IAllorders _allorders;
        private readonly ShopCart _shopCart;
        public OrderController(IAllorders allorders, ShopCart shopCart)
        {
            _allorders = allorders;
            _shopCart = shopCart;

        }

        public IActionResult Checkout()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Checkout(Order order)
        {
            _shopCart.Listshopcartitems = _shopCart.GetShopCartItems();
            if (_shopCart.Listshopcartitems.Count == 0) {
                ModelState.AddModelError("","You must have products");
            }
            if (ModelState.IsValid) {
                _allorders.CreateOrder(order);
                return RedirectToAction("Complete");
            }
            return View(order);
        }
        public IActionResult Complete() {
            ViewBag.Message = "You are confirm your order";
            return View();
        }
    }
}
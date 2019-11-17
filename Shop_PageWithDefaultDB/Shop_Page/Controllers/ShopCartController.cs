using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Shop_Page.Interfaces;
using Shop_Page.Models;
using Shop_Page.Repository;
using Shop_Page.ViewModels;

namespace Shop_Page.Controllers
{
    public class ShopCartController : Controller
    {
        private readonly IAllCar _cartRepository;
        private readonly ShopCart _shopcart;
        public ShopCartController(IAllCar carRepository, ShopCart shopCart)
        {
            _cartRepository = carRepository;
            _shopcart = shopCart;
        }

        public IActionResult Index()
        {
            var items = _shopcart.GetShopCartItems();
            _shopcart.Listshopcartitems = items;
            ShopCartViewModel shopCartviewmodel = new ShopCartViewModel()
            {
                shopCart = _shopcart
            };

            return View(shopCartviewmodel);
        }

        public RedirectToActionResult addCart(int? id) {//IActionResult
            var car = _cartRepository.Cars.FirstOrDefault(c =>c.Id == id);
            if (car != null) {
                _shopcart.AddToCard(car); //AddToCard  _shopcart-in ozune mexsus methodudur.
            }
            return RedirectToAction("Index");
        }
    }
}   
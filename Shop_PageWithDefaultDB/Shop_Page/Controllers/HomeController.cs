using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Shop_Page.DAL;
using Shop_Page.Interfaces;
using Shop_Page.Mocks;
using Shop_Page.Models;
using Shop_Page.Repository;
using Shop_Page.ViewModels;

namespace Shop_Page.Controllers
{
    public class HomeController : Controller
    {
        private readonly IAllCar _cartRepository;


        public HomeController(IAllCar carRepositoryb)
        {
              _cartRepository = carRepositoryb;
      
        }

        public IActionResult Index() 
        {
            HomeViewModel homeViewModel = new HomeViewModel()
            {
                favCars = _cartRepository.GetFavoriteCar
               
            };
           
            return View(homeViewModel);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Shop_Page.Interfaces;
using Shop_Page.Models;
using Shop_Page.ViewModels;

namespace Shop_Page.Controllers
{
    public class CarsController : Controller
    {
        private readonly IAllCar _cars;
        private readonly IAllCategory _categories;
        public CarsController(IAllCar allCars, IAllCategory allCategories)
        {
            _cars = allCars;
            _categories = allCategories;
        }

        [Route("[controller]/[action]/{category?}")]
        public IActionResult Index(string category)
        {
            string _category = category;
            string currentcategory = "";
            IEnumerable<Car> cars = null;


            if (string.IsNullOrEmpty(category))
            {
                cars = _cars.Cars.OrderBy(i => i.Id);           
            }
            else {
               // List<Category> categories = _categories.AllCategories
                foreach (var item in _categories.AllCategories)
                {
                    if (string.Equals(item.CategoryName, category))
                    {
                        cars = _cars.Cars.Where(c => c.Category.CategoryName.Equals(category)).OrderBy(i => i.Id);
                    }
                    
                }

            }

            if (cars == null) {
                cars = _cars.Cars.OrderBy(i => i.Id);
            }

            CarsViewModel obj = new CarsViewModel();
            obj.allCars = cars;
            obj.currentCategory = currentcategory;


            return View(obj);
        }
    }
}
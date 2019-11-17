using Shop_Page.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop_Page.ViewModels
{
    public class CarsViewModel
    {
        public IEnumerable<Car> allCars { get; set; }
        public string currentCategory  { get; set; }
    }
}

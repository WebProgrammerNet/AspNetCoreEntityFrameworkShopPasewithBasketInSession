using Shop_Page.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop_Page.Interfaces
{
    public interface IAllCar
    {
        IEnumerable<Car> Cars { get; }
        IEnumerable<Car> GetFavoriteCar { get; }
        Car getObjectCar(int carId);
    }
}

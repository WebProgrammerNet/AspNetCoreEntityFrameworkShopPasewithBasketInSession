using Microsoft.EntityFrameworkCore;
using Shop_Page.DAL;
using Shop_Page.Interfaces;
using Shop_Page.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop_Page.Repository
{
    public class CarRepository : IAllCar
    {
        private ShopDb _dbshop;

        public CarRepository(ShopDb shopdb)
        {
            _dbshop = shopdb;
        }
        public IEnumerable<Car> Cars => _dbshop.Cars.Include(c =>c.Category);

        public IEnumerable<Car> GetFavoriteCar => _dbshop.Cars.Where(c => c.IsFavorite).Include(c =>c.Category);
        

        public Car getObjectCar(int carId) => _dbshop.Cars.FirstOrDefault(c => c.Id == carId);

    }
}

using Shop_Page.Interfaces;
using Shop_Page.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop_Page.Mocks
{
    public class MockAllCars : IAllCar
    {
        private readonly IAllCategory _allCategory = new MockAllCategory();
        public IEnumerable<Car> Cars
        {
            get {
                return new List<Car>()
                {
                    new  Car {Id = 1, ShortDesc="Best Of All", longDesc="Some quick example text to build on the card title and make up the bulk of the card's content.", Img="Tesla.jpg", Price =400, IsFavorite = true, Name="Tesla", aviable =true, Category = _allCategory.AllCategories.FirstOrDefault(c=>c.Id == 1), CategoryId = 1},
                    new  Car {Id = 2, ShortDesc="It is very economic", longDesc="Some quick example text to build on the card title and make up the bulk of the card's content.", Img="Tuareg.jpg", Price =600, IsFavorite = true, Name="Tuareg", aviable =true, Category = _allCategory.AllCategories.FirstOrDefault(c=>c.Id == 2), CategoryId = 2},
                    new  Car {Id = 3, ShortDesc="Iam Strong", longDesc="Some quick example text to build on the card title and make up the bulk of the card's content.", Img="Elantra.jpg", Price =100, IsFavorite = true, Name="Elantra", aviable =true, Category = _allCategory.AllCategories.FirstOrDefault(c=>c.Id == 2), CategoryId = 2},

                };

            }

        
        }
        public IEnumerable<Car> GetFavoriteCar { get => throw new NotImplementedException();}

        public Car getObjectCar(int carId)
        {
            throw new NotImplementedException();
        }
    }
}

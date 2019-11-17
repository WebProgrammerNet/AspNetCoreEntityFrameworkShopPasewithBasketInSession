using Shop_Page.Interfaces;
using Shop_Page.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop_Page.Mocks
{
    public class MockAllCategory : IAllCategory
    {

        public IEnumerable<Category> AllCategories {
            get  {

                return new List<Category>()
                {
                    new  Category {Id =1, CategoryName = "Electrican", Description= "Globalization allows us to create multilingual web sites with ASP.NET Core." },
                    new  Category {Id =2, CategoryName = "Diesel", Description= "Globalization allows us to create multilingual web sites with ASP.NET Core." },
                    new  Category {Id =3, CategoryName = "Benzin", Description= "Globalization allows us to create multilingual web sites with ASP.NET Core." },

                };
            }
        }
    }
}

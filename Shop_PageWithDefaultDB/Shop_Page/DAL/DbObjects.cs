using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Shop_Page.Models;
using System.Collections.Generic;
using System.Linq;

namespace Shop_Page.DAL
{
    public class DbObjects
    {
        #region
        //public static void Initial(IApplicationBuilder app)
        //{
        //    ShopDb content;
        //    using (var scope = app.ApplicationServices.CreateScope())
        //    {

        //        content = scope.ServiceProvider.GetRequiredService<ShopDb>();
        //    }

        //    // ShopDb content = app.ApplicationServices.GetRequiredService<ShopDb>();//Scope -nin icinde yazacayiq
        //    if (!content.Categories.Any())
        //    {
        //        content.Categories.AddRange(Categories.Select(c => c.Value));
        //    };
        //    if (!content.Cars.Any())
        //    {
        //        content.AddRange(
        //            new Car { Id = 1, ShortDesc = "Best Of All", longDesc = "Some quick example text to build on the card title and make up the bulk of the card's content.", Img = "Tesla.jpg", Price = 400, IsFavorite = true, Name = "Tesla", aviable = true, Category = Categories["Electrican"] },
        //            new Car { Id = 2, ShortDesc = "It is very economic", longDesc = "Some quick example text to build on the card title and make up the bulk of the card's content.", Img = "Tuareg.jpg", Price = 600, IsFavorite = true, Name = "Tuareg", aviable = true, Category = Categories["Diesel"] },
        //            new Car { Id = 3, ShortDesc = "Iam Strong", longDesc = "Some quick example text to build on the card title and make up the bulk of the card's content.", Img = "Elantra.jpg", Price = 100, IsFavorite = true, Name = "Elantra", aviable = true, Category = Categories["Benzin"] }
        //            );
        //    }
        //}
        #endregion

        public static void  Initial(ShopDb content)
        {


            // ShopDb content = app.ApplicationServices.GetRequiredService<ShopDb>();//Scope -nin icinde yazacayiq
            if (!content.Categories.Any())
            {
                content.Categories.AddRange(Categories.Select(c => c.Value));
            };
            List<Car> carList = new List<Car>() {
                    new Car { ShortDesc = "Best Of All", longDesc = "Some quick example text to build on the card title and make up the bulk of the card's content.", Img = "Tesla.jpg", Price = 400, IsFavorite = true, Name = "Tesla", aviable = true, Category = Categories["Electrican"] },
                    new Car { ShortDesc = "It is very economic", longDesc = "Some quick example text to build on the card title and make up the bulk of the card's content.", Img = "Tuareg.jpg", Price = 600, IsFavorite = true, Name = "Tuareg", aviable = true, Category = Categories["Diesel"] },
                    new Car { ShortDesc = "Iam Strong", longDesc = "Some quick example text to build on the card title and make up the bulk of the card's content.", Img = "Elantra.jpg", Price = 100, IsFavorite = true, Name = "Elantra", aviable = true, Category = Categories["Benzin"] },

                  
                    new Car { ShortDesc = "Best Of All", longDesc = "Some quick example text to build on the card title and make up the bulk of the card's content.", Img = "Audio.jpg", Price = 400, IsFavorite = true, Name = "Audio", aviable = true, Category = Categories["Benzin"] },
                    new Car { ShortDesc = "It is very economic", longDesc = "Some quick example text to build on the card title and make up the bulk of the card's content.", Img = "Base.jpg", Price = 600, IsFavorite = true, Name = "Base", aviable = true, Category = Categories["Diesel"] },
                    new Car { ShortDesc = "Iam Strong", longDesc = "Some quick example text to build on the card title and make up the bulk of the card's content.", Img = "Bmv.jpg", Price = 100, IsFavorite = true, Name = "BMV", aviable = true, Category = Categories["Benzin"] },

                   new Car { ShortDesc = "Best Of All", longDesc = "Some quick example text to build on the card title and make up the bulk of the card's content.", Img = "Tesla_Fast.jpg", Price = 400, IsFavorite = true, Name = "Tesla_Fast", aviable = true, Category = Categories["Electrican"] },
                  new Car { ShortDesc = "It is very economic", longDesc = "Some quick example text to build on the card title and make up the bulk of the card's content.", Img = "Nissan.jpg", Price = 600, IsFavorite = false, Name = "Nissan", aviable = true, Category = Categories["Diesel"] },
                  new Car { ShortDesc = "Iam Strong", longDesc = "Some quick example text to build on the card title and make up the bulk of the card's content.", Img = "Nexia.jpg", Price = 100, IsFavorite = false, Name = "Nexia", aviable = true, Category = Categories["Benzin"] },
                  new Car { ShortDesc = "Iam Strong", longDesc = "Some quick example text to build on the card title and make up the bulk of the card's content.", Img = "AudioEco.jpg", Price = 100, IsFavorite = true, Name = "AudioEco", aviable = true, Category = Categories["Benzin"] }




            };


            if (!content.Cars.Any())
            {
                foreach (Car  car in carList)
                {
                    content.Add(car);
                   
                }
             
            }
          content.SaveChanges();
           
        }

        public static Dictionary<string, Category> category;

        public static Dictionary<string, Category> Categories
        {
            get
            {
                if (category == null)
                {
                    var list = new Category[] {
                    new  Category { CategoryName = "Electrican", Description= "Globalization allows us to create multilingual web sites with ASP.NET Core." },
                    new  Category {CategoryName = "Diesel", Description= "Globalization allows us to create multilingual web sites with ASP.NET Core." },
                    new  Category {CategoryName = "Benzin", Description= "Globalization allows us to create multilingual web sites with ASP.NET Core." }
                    };
                    category = new Dictionary<string, Category>();
                    foreach (Category item in list)
                    {
                        category.Add(item.CategoryName, item);
                    }
                }
                return category;
            }
        }

    }
}

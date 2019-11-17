using Shop_Page.DAL;
using Shop_Page.Interfaces;
using Shop_Page.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop_Page.Repository
{
    public class CategoryRepository : IAllCategory
    {
        private ShopDb _dbshop;
        public CategoryRepository(ShopDb shopdb)
        {
            _dbshop = shopdb;
        }

        public IEnumerable<Category> AllCategories => _dbshop.Categories;

        //public IEnumerable<Category> AllCategories
        //{
        //    get
        //    {
        //        return _dbshop.Categories;
        //    }
        //}
    }

   
}


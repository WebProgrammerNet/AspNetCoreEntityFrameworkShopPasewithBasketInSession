using Shop_Page.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop_Page.Interfaces
{
    public interface IAllCategory
    {
        IEnumerable<Category> AllCategories { get; }
    }
}

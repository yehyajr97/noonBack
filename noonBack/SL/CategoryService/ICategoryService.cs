using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.CategoryService
{
    interface ICategoryService
    {
        IEnumerable<Category> GetAllCategory();
        Category GetCategory(int id);
        void InsertCategory(Category category);
        void UpdateCategory(Category category);
        void DeleteCategory(int id);
    }
}

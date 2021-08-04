using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.SubCategoryService
{
   public interface ISubCategoryService
    {
        IEnumerable<SubCategory> GetAllSubCategory();
        SubCategory GetSubCategory(int id);
        void InsertSubCategory(SubCategory subCategory);
        void UpdateSubCategory(SubCategory subCategory);
        void DeleteSubCategory(int id);
    }
}

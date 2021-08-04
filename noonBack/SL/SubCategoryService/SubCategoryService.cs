using DAL.Models;
using RepoL.Repository_pattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.SubCategoryService
{
   public class SubCategoryService : ISubCategoryService
    {
        #region Property  
        private IRepository<SubCategory> _repository;
        #endregion

        #region Constructor  
        public SubCategoryService(IRepository<SubCategory> repository)
        {
            _repository = repository;
        }
        #endregion

        public IEnumerable<SubCategory> GetAllSubCategory()
        {
            return _repository.GetAll();
        }

        public SubCategory GetSubCategory(int id)
        {
            return _repository.Get(id);
        }

        public void InsertSubCategory(SubCategory subCategory)
        {
            _repository.Insert(subCategory);
        }
        public void UpdateSubCategory(SubCategory subCategory)
        {
            _repository.Update(subCategory);
        }

        public void DeleteSubCategory(int id)
        {
            SubCategory subCategory = GetSubCategory(id);
            _repository.Remove(subCategory);
            _repository.SaveChanges();
        }
    }
}

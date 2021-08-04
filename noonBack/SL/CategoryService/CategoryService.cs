using DAL.Models;
using RepoL.Repository_pattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.CategoryService
{
    public class CategoryService : ICategoryService
    {
        #region Property  
        private IRepository<Category> _repository;
        #endregion

        #region Constructor  
        public CategoryService(IRepository<Category> repository)
        {
            _repository = repository;
        }
        #endregion

        public IEnumerable<Category> GetAllCategory()
        {
            return _repository.GetAll();
        }

        public Category GetCategory(int id)
        {
            return _repository.Get(id);
        }

        public void InsertCategory(Category category)
        {
            _repository.Insert(category);
        }
        public void UpdateCategory(Category category)
        {
            _repository.Update(category);
        }

        public void DeleteCategory(int id)
        {
            Category category = GetCategory(id);
            _repository.Remove(category);
            _repository.SaveChanges();
        }
    }
}

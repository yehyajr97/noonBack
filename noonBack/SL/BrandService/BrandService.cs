using DAL.Models;
using RepoL.Repository_pattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.BrandService
{
    class BrandService : IBrandService
    {
        #region Property  
        private IRepository<Brand> _repository;
        #endregion

        #region Constructor  
        public BrandService(IRepository<Brand> repository)
        {
            _repository = repository;
        }
        #endregion

        public IEnumerable<Brand> GetAllBrands()
        {
            return _repository.GetAll();
        }

        public Brand GetBrand(int id)
        {
            return _repository.Get(id);
        }

        public void InsertBrand(Brand brand)
        {
            _repository.Insert(brand);
        }
        public void UpdateBrand(Brand brand)
        {
            _repository.Update(brand);
        }

        public void DeleteBrand(int id)
        {
            Brand brand = GetBrand(id);
            _repository.Remove(brand);
            _repository.SaveChanges();
        }
    }
}

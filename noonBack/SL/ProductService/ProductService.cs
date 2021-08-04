using DAL.Models;
using RepoL.Repository_pattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.ProductService
{
    public class ProductService : IProductService
    {
        #region Property  
        private IRepository<Product> _repository;
        #endregion

        #region Constructor  
        public ProductService(IRepository<Product> repository)
        {
            _repository = repository;
        }
        #endregion

        public IEnumerable<Product> GetAllProducts()
        {
            return _repository.GetAll();
        }

        public Product GetProduct(int id)
        {
            return _repository.Get(id);
        }

        public void InsertProduct(Product product)
        {
            _repository.Insert(product);
        }
        public void UpdateProduct(Product product)
        {
            _repository.Update(product);
        }

        public void DeleteProduct(int id)
        {
            Product product = GetProduct(id);
            _repository.Remove(product);
            _repository.SaveChanges();
        }

    }
}

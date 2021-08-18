using DAL.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using RepoL.Repository_pattern;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.FileService
{
  public  class ProductImagesService :IProductImagesService
    {
        #region Property  
        private IHostingEnvironment _hostingEnvironment;
        private IRepository<ProductImages> _repository;
        #endregion
        #region Constructor  
        public ProductImagesService(IHostingEnvironment hostingEnvironment, IRepository<ProductImages> repository)
        {
            _hostingEnvironment = hostingEnvironment;
            _repository = repository;
        }
        #endregion


        public IEnumerable<ProductImages> GetAll()
        {
            return _repository.GetAll();
        }

        #region Upload File  
        public void Upload(int id)
        {
           
        }
        #endregion

            
        public ProductImages GetByProductId(int id)
        {
          return  _repository.Get(id);
        }

        public void InsertProductImage(ProductImages productImages)
        {
            _repository.Insert(productImages);
        }

        
    }
}

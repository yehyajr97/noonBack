using DAL.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.FileService
{
    public interface IProductImagesService
    {
        IEnumerable<ProductImages> GetAll();
        void Upload(int id);
         ProductImages GetByProductId(int  id);
         
        void InsertProductImage(ProductImages productImages);
        
    }
}

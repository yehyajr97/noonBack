using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.ProductImagesService
{
    public interface IProductImagesService
    {
        IEnumerable<ProductImages> GetAllProductImages();
        ProductImages GetProductImages(int id);
        void InsertProductImages(ProductImages productImages);
        void UpdateProductImages(ProductImages productImages);

        void DeleteProductImages(int id);

    }
}

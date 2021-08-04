using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.BrandService
{
    public interface IBrandService
    {
        IEnumerable<Brand> GetAllBrands();
        Brand GetBrand(int id);
        void InsertBrand(Brand brand);
        void UpdateBrand(Brand brand);
        void DeleteBrand(int id);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    class Category
    {
        public int CatId { get; set; }
        public string CatName { get; set; }

        public ICollection<subCategory> SubCat { get; set; }
        public ICollection<Brand> Brand { get; set; }
        public ICollection<Product> Product { get; set; }
    }
}

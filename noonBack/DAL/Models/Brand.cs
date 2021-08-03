using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    class Brand
    {
        public int Id { get; set; }
        public string BrandName { get; set; }
        public string LogoPath { get; set; }

        public Category Category { get; set; }




    }
}

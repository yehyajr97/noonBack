using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    class Product
    {
        public int productId { get; set; }
        public int description { get; set; }
        public string productName { get; set; }
        public float price { get; set; }
        public int stock { get; set; }
        public int imgPath { get; set; }

    }
}

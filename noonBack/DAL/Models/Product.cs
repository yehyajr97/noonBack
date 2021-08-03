using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    class Product
    {
        public int Id { get; set; }
        public int Description { get; set; }
        public string ProductName { get; set; }
        public float Price { get; set; }
        public int Stock { get; set; }
        public int ImgPath { get; set; }

        public ICollection<Review> Review { get; set; }
        public  Order Order { get; set; }
        public Category Category { get; set; }


    }
}

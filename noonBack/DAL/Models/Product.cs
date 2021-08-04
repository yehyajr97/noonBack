using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
   public class Product : BaseEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public int Discount { get; set; }
        public int Stock { get; set; }
        public string ImgPath { get; set; }

        public virtual ICollection<Review> Review { get; set; }
        public virtual  Order Order { get; set; }
        public virtual Category Category { get; set; }


    }
}

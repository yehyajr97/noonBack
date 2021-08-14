using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
   public class Product : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public int Discount { get; set; }
        public int Stock { get; set; }
        [Required]
        public int CategoryId { get; set; }

        public virtual ICollection<Review> Review { get; set; }
        public virtual ICollection<ProductImages> ProductImages { get; set; }
        public virtual  Order Order { get; set; }
        [ForeignKey("CategoryId")]
        public virtual Category Category { get; set; }


    }
}

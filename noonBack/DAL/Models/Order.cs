using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
  public  class Order : BaseEntity
    {
        public string State { get; set; }
        public string Date { get; set; }
        public string Description { get; set; }
        public int TotalPrice { get; set; }
        public int Discount { get; set; }
        [Required]
        public string UserId { get; set; }

        public virtual ICollection<Product> Products { get; set; }
        [ForeignKey("UserId")]
        public virtual ApplicationUser User { get; set; }

    }
}

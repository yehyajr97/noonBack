using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
  public  class Order
    {
        public int Id { get; set; }
        public string State { get; set; }
        public string Date { get; set; }
        public string Description { get; set; }
        public int TotalPrice { get; set; }
        public int Discount { get; set; }

        public virtual ICollection<Product> Products { get; set; }
        public virtual ApplicationUser User { get; set; }

    }
}

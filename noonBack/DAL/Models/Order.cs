using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    class Order
    {
        public int Id { get; set; }
        public string State { get; set; }

        public ICollection<Product> Product { get; set; }

    }
}

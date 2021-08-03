using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    class Review
    {
        public int product_id { get; set; }
        public int user_id { get; set; }
        public string commnet { get; set; }
    }
}

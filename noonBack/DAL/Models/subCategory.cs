using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    class subCategory
    {
        public int Id { get; set; }
        public string SubcatName { get; set; }

        public Category Category { get; set; }
    }
}

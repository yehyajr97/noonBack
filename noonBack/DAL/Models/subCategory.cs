using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class subCategory
    {
        public int Id { get; set; }
        public string SubcatName { get; set; }

        public virtual Category Category { get; set; }
    }
}

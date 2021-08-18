using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class SubCategory : BaseEntity
    {
        public string SubcatName { get; set; }
       
       
        public virtual ICollection<Product>  Product { get; set; }

    }
}

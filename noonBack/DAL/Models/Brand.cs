using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Brand: BaseEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LogoPath { get; set; }

        public virtual Category Category { get; set; }




    }
}

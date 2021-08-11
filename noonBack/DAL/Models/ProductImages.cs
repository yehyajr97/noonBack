using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
   public class ProductImages:BaseEntity
    {
        public int Id { get; set; }
        [NotMapped]
        public IFormFile Image { get; set; }
        public string ImagePath { get; set; }

        public virtual Product Product { get; set; }
    }
}

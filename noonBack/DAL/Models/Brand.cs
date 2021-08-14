﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Brand: BaseEntity
    {
        public string Name { get; set; }
        public string LogoPath { get; set; }
        [Required]
        public int CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public virtual Category Category { get; set; }




    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    class Review
    {
        public int Product_id { get; set; }
        public int User_id { get; set; }
        public string Commnet { get; set; }

        public Product Product { get; set; }
    }
}

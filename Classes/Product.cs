﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FB
{
    
    class Product
    {
       // [PrimaryKey, AutoIncrement]
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public int ProductPrice { get; set; }
        public string ProductDescription { get; set; }
        public string NutritionalValues { get; set; }
    }
}

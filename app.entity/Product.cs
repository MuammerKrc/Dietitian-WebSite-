using System;
using System.Collections.Generic;

namespace app.entity
{
    public class Product : BaseClass
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
using System;
using System.Collections.Generic;

namespace app.entity
{
    public class Product:BaseClass
    {
        public string Name { get; set; } 
        public string Url { get; set; } 
        public double? Price { get; set; } 
        public string Description { get; set; } 
        public string ImageUrl { get; set; }
        public bool IsApproved { get; set; }
        public DateTime DateAdded{get;set;}
        public int CategoryId{get;set;}
        public Category Category{get;set;}
    }
}
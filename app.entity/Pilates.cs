using System;

namespace app.entity
{
    public class Pilates:BaseClass
    {
        public string Name{get;set;}
        public DateTime DateStart { get; set; }
        public Customer Customer { get; set; }
        public int CustomerId{get;set;}
    }
}
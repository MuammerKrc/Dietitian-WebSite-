using System;
using System.Collections.Generic;

namespace app.entity
{
    public class Diet:BaseClass
    {
        public int StartingWeight{get;set;}
        public int Height{get;set;}
        public int StartingWaistline{get;set;}
        public int StartingBreastSize{get;set;}
        public DateTime DateStart{ get; set; }
        public DateTime DateEnd{get;set;}
        public Customer Customer{get;set;}
        public List<DietWekkly> DietWekklies{get;set;}
    }
}
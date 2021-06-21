using System;

namespace app.entity
{
    public class MyCart:BaseClass
    {
        public string ProductName{get;set;}
        public bool IsPaid{get;set;}
        public int Price{get;set;}
        public string PaidType{get;set;}
        public DateTime Time{get;set;}
        public int CustomerId{get;set;}
        public Customer customer{get;set;}
    }
}
using System;

namespace app.entity
{
    public class PackageRequest:BaseClass
    {
        public int CustomerId { get; set; }
        public string FullName{get;set;}
        public DateTime RequestTime{get;set;}
        public string PackageName{get;set;}
    }
}
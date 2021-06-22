using System;

namespace app.entity
{
    public class PackageRequest : BaseClass
    {
        public int CustomerId { get; set; }
        public string FullName { get; set; }
        public DateTime RequestTime { get; set; }
        public PackageName typeOfRequest { get; set; }
        public string PhoneNumber { get; set; }

    }
    public enum PackageName
    {
        OnlineDiet = 1,
        
        YüzyüzeDiet = 2,
        OnlinePilates=3,
        YüzyüzePilates
    }
}
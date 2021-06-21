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
        Diet = 1,
        Pilates = 2
    }
}
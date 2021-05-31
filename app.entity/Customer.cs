using System.Collections.Generic;

namespace app.entity
{
    public class Customer : BaseClass
    {
        public string UserId { get; set; }
        public bool Gender{get;set;}
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Mail { get; set; }
        public int? DietId{get;set;}
        public Diet Diet{get;set;}
        public int? PilatesId{get;set;}
        public Pilates Pilates{get;set;}
    }
}
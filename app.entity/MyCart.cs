namespace app.entity
{
    public class MyCart:BaseClass
    {
        public bool IsPaid{get;set;}
        public string PaidType{get;set;}
        public int CustomerId{get;set;}
        public Customer customer{get;set;}
        public int ProductId{get;set;}
        public Product Product{get;set;}
    }
}
namespace app.webui.Models
{
    public class CustomerModel
    {
        public string UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Mail { get; set; }
        public DietModel diet{get;set;}
        public PilatesModel Pilates{get;set;}
    }
}
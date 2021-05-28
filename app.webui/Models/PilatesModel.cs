using System;

namespace app.webui.Models
{
    public class PilatesModel
    {
        public DateTime DateStart { get; set; }
        public int RemainingPackages { get; set; }
        public int CustomerId { get; set; }
        public CustomerModel Customer { get; set; }
    }
}
using System;

namespace app.webui.Models
{
    public class DietModel
    {
        public DateTime DateStart { get; set; }
        public DateTime DateEnd { get; set; }
        public int CustomerId { get; set; }
        public CustomerModel Customer { get; set; }
    }
}
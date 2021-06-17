using System.Collections.Generic;

namespace app.entity
{
    public class Cart:BaseClass
    {
        public int CartID{get;set;}
        public string UserID{get;set;}
        public List<CartItem> cartItems{get;set;}

    }
}
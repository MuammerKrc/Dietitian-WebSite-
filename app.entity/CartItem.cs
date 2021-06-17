using System.Collections.Generic;
namespace app.entity
{
    public class CartItem:BaseClass
    {
       public int ProductId{get;set;}
       public Product product{get;set;}
       public int CartID{get;set;}
       public Cart cart{get;set;}
       public int Quantity{get;set;}
    }
}
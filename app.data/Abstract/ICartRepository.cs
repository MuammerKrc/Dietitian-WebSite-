using app.entity;

namespace app.data.Abstract
{
    public interface ICartRepository:IRepository<Cart>
    {
        Cart GetCartUserId(string UserID);
        void DeleteFromCart(int cartID,int productId);
        void ClearCart(int cartID);
    }
}
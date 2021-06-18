using System.Linq;
using app.data.Abstract;
using app.entity;
using Microsoft.EntityFrameworkCore;


namespace app.data.Concret
{
    public class CartRepository : Repository<Cart>, ICartRepository
    {
        public CartRepository(AppContext context) : base(context)
        {

        }
        public AppContext appContext { get { return context as AppContext; } }
        // public void ClearCart(int cartID)
        // {

        //     var cmd = @"delete from CartItems where CartID=@p0";
        //     appContext.Database.ExecuteSqlRaw(cmd, cartID);
        // }

        // public void DeleteFromCart(int cartID, int productId)
        // {

        //     var cmd = @"delete from CartItems where CartID=@p0 and ProductId=@p1";
        //     appContext.Database.ExecuteSqlRaw(cmd, cartID, productId);
        // }

        // public Cart GetCartUserId(string _UserID)
        // {

        //     var cart = appContext.Carts.AsQueryable();

        //     return cart.Where(i => i.UserID == _UserID)
        //             .Include(i => i.cartItems)
        //             .ThenInclude(i => i.product)
        //             .FirstOrDefault();
        // }

        //  public override void Update(Cart entity)
        //  {

        //      appContext.Carts.Update(entity);
        //  }
    }
}
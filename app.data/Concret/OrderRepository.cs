using System.Collections.Generic;
using System.Linq;
using app.data.Abstract;
using app.entity;
using Microsoft.EntityFrameworkCore;


namespace app.data.Concret
{
    public class OrderRepository : Repository<Order>, IOrderRepository
    {
        public OrderRepository(AppContext context):base(context)
        {
            
        }
        private AppContext AppContext{get{return context as AppContext;}}
        
        
        // public List<Order> GetOrders(string userID)
        // {
        //     var orders = AppContext.Orders
        //                             .Include(i => i.OrderItems)
        //                             .ThenInclude(i => i.Product)
        //                             .AsQueryable();

        //     if (!string.IsNullOrEmpty(userID))
        //     {
        //         orders.Where(i => i.UserID == userID);
        //     }
        //     return orders.ToList();
        // }
    }
}
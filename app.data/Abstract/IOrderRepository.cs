using System.Collections.Generic;
using app.entity;

namespace app.data.Abstract
{
    public interface IOrderRepository : IRepository<Order>
    {
        List<Order> GetOrders(string userID);
    }
}
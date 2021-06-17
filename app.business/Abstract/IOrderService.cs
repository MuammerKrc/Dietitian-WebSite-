using System.Collections.Generic;
using app.entity;

namespace app.business.Abstract
{
    public interface IOrderService
    {
        void Create(Order entity);
        List<Order> GetOrders(string userID);
    }
}
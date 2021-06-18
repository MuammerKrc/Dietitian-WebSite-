using System.Collections.Generic;
using app.business.Abstract;
using app.data.Abstract;
using app.entity;

namespace app.business.Concret
{
    public class OrderManager : IOrderService
    {
        private readonly IUnitOfWork unitOfWork;
        public OrderManager(IUnitOfWork _unitOfWork)
        {
            unitOfWork = _unitOfWork;
        }
        // public void Create(Order entity)
        // {
        //     unitOfWork.Orders.Create(entity);
        //     unitOfWork.Save();
        // }

        // public List<Order> GetOrders(string userID)
        // {
        //     return unitOfWork.Orders.GetOrders(userID);
        // }
    }
}
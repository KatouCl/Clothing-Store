using System.Collections.Generic;
using KS.ViewModels.Order;

namespace KS.Interfaces.DataAccess.BusinessLogic.Services
{
    public interface IOrderService
    {
        IEnumerable<OrderListVm> GetOrderFromUser(string customerId);
        IEnumerable<OrderListVm> GetOrders();
        IEnumerable<OrderDetailsItemVm> GetOrderDetailsItem(string customerId, long orderId);
        IEnumerable<OrderDetailsItemVm> GetOrderDetails(long orderId);
    }
}
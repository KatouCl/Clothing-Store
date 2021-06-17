using System.Threading.Tasks;
using KS.Interfaces.DataAccess.BusinessLogic.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace KS.WEB.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles="Admin")]
    public class OrderController : Controller
    {
        private readonly IOrderService _orderService;

        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        public IActionResult Index()
        {
            var orderList = _orderService.GetOrders();
            return View(orderList);
        }

        public IActionResult OrderDetails(long orderId)
        {
            ViewBag.OrderId = orderId;
            var orderDetails =  _orderService.GetOrderDetails(orderId);
            return View(orderDetails);
        }
    }
}
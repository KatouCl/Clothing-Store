using System.Threading.Tasks;
using KS.Entities;
using KS.Interfaces.DataAccess.BusinessLogic.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace KS.WEB.Controllers
{
    [Authorize]
    public class OrderController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IOrderService _orderService;

        public OrderController(UserManager<ApplicationUser> userManager,
            IOrderService orderService)
        {
            _userManager = userManager;
            _orderService = orderService;
        }

        // GET
        public async Task<IActionResult> Index()
        {
            var currentUser = await _userManager.GetUserAsync(HttpContext.User);
            var orderList = _orderService.GetOrderFromUser(currentUser.Id);
            return View(orderList);
        }

        public async Task<IActionResult> OrderDetails(long orderId)
        {
            var currentUser = await _userManager.GetUserAsync(HttpContext.User);
            var orderDetails = _orderService.GetOrderDetailsItem(currentUser.Id, orderId);
            return View(orderDetails);
        }
    }
}
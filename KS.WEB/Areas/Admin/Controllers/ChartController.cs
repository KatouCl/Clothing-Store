using System.Linq;
using KS.Entities;
using KS.Interfaces.DataAccess.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace KS.WEB.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles="Admin")]
    public class ChartController : Controller
    {
        private readonly IBaseRepository<Order> _orderRepository;
        private readonly IBaseRepository<OrderItem> _orderItemRepository;

        public ChartController(IBaseRepository<Order> orderRepository,
            IBaseRepository<OrderItem> orderItemRepository)
        {
            _orderRepository = orderRepository;
            _orderItemRepository = orderItemRepository;
        }

        public IActionResult Order()
        {
            var orders = _orderRepository.GetAllQuery()
                .GroupBy(x => new {group = x.Price, z = new {zone = x.Customer}})
                .Select(group => new
                {
                    group.Key.group,
                    group.Key.z
                    
                }).ToList();
            ViewBag.Price = orders;
            return Json(orders);
        }
    }
}
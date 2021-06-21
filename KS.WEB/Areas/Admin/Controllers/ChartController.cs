using System;
using System.Linq;
using KS.Entities;
using KS.Interfaces.DataAccess.BusinessLogic.Services;
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
        private readonly IOrderService _orderService;
        private readonly IBaseRepository<OrderItem> _orderItemRepository;

        public ChartController(
            IBaseRepository<Order> orderRepository,
            IBaseRepository<OrderItem> orderItemRepository, 
            IOrderService orderService)
        {
            _orderRepository = orderRepository;
            _orderItemRepository = orderItemRepository;
            _orderService = orderService;
        }

        public IActionResult Order(DateTime firstTime, DateTime? lastTime)
        {
            var orderList = _orderService.GetOrders()
                .Where(x => x.CreationDate <= firstTime)
                .Where(x => x.CreationDate >= lastTime);
            ViewBag.Price = orderList;
            return View(orderList);
        }
    }
}
using System;
using System.Linq;
using KS.Entities;
using KS.Interfaces.DataAccess.BusinessLogic.Services;
using KS.Interfaces.DataAccess.Repositories;
using KS.ViewModels.Order;
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

        public IActionResult Order(DateTime firstTime, DateTime lastTime)
        {
            var orderList = _orderService.GetOrders()
                .Where(x => x.CreationDate >= firstTime && x.CreationDate <= lastTime);
            
            ViewBag.firstTime = firstTime.ToString("yyyy-MM-dd")?? DateTime.Now.ToString("yyyy-MM-dd");
            ViewBag.lastTime = lastTime.ToString("yyyy-MM-dd")?? DateTime.Now.ToString("yyyy-MM-dd");
            ViewBag.Price = orderList;
            return View(orderList);
        }
        
        public IActionResult OrdersItems(DateTime firstTime, DateTime lastTime)
        {
            var ordersItemsList = _orderItemRepository.GetAllQuery()
                .Where(x => x.CreationDate >= firstTime && x.CreationDate <= lastTime)
                .Select(x => new OrderDetailsItemVm
                {
                    Id = x.Id,
                    CoverImageUrl = x.Product.CoverImageUrl,
                    ProductName = x.Product.Name,
                    Quantity = x.Quantity,
                    Price = x.Price,
                    TotalPrice = x.TotalPrice,
                    CreationDate = x.CreationDate
                }).ToList();
            
            ViewBag.firstTime = firstTime.ToString("yyyy-MM-dd")?? DateTime.Now.ToString("yyyy-MM-dd");
            ViewBag.lastTime = lastTime.ToString("yyyy-MM-dd")?? DateTime.Now.ToString("yyyy-MM-dd");
            return View(ordersItemsList);
        }
    }
}
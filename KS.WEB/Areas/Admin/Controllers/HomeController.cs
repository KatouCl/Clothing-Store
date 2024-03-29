﻿using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using KS.Entities;
using KS.Interfaces.DataAccess.BusinessLogic.Services;
using KS.Interfaces.DataAccess.Repositories;
using KS.ViewModels.Order;
using KS.ViewModels.WishList;
using KS.WEB.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using X.PagedList;

namespace KS.WEB.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IBaseRepository<Order> _orderRepository;
        private readonly IBaseRepository<WishList> _wishListRepository;
        private readonly IBaseRepository<OrderItem> _orderItemRepository;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IOrderService _orderService;

        public HomeController(
            ILogger<HomeController> logger,
            IBaseRepository<Order> orderRepository,
            UserManager<ApplicationUser> userManager,
            IBaseRepository<OrderItem> orderItemRepository,
            IBaseRepository<WishList> wishListRepository, 
            IOrderService orderService)
        {
            _logger = logger;
            _orderRepository = orderRepository;
            _userManager = userManager;
            _orderItemRepository = orderItemRepository;
            _wishListRepository = wishListRepository;
            _orderService = orderService;
        }

        public async Task<IActionResult> Index()
        {
            var lastOrdersList = await _orderRepository.GetAllQuery()
                .OrderByDescending(x => x.Id)
                .Select(x => new LastOrdersVm
                {
                    Id = x.Id,
                    OrderId = x.Id,
                    CustomerName = x.Customer.Email,
                    CreationDate = x.CreationDate,
                    TotalPrice = x.Price
                }).ToListAsync();

            var wishList = await _wishListRepository.GetAllQuery()
                .OrderByDescending(x => x.Id)
                .Select(x => new WishListVm
                {
                    Id = x.Id,
                    CustomerEmail = x.Customer.Email,
                    ProductName = x.Product.Name,
                    ProductId = x.Product.Id,
                    ImageUrl = x.Product.CoverImageUrl,
                    Price = x.Price
                })
                .Take(5)
                .ToListAsync();
            
            var model = new OrderHomeVm
            {
                LastOrdersVms = lastOrdersList,
                WishListVms = wishList
            };

            ViewBag.Users = _userManager.Users.Count().ToString();
            ViewBag.Orders = _orderRepository.GetAllQuery().Count().ToString();
            ViewBag.GoodsSold = _orderService.GetOrders().Select(x => x.QuantityProduct).Sum().ToString();
            ViewBag.MoneyEarned = _orderRepository.GetAllQuery().Select(x => x.Price).Sum().ToString("0");

            return View(model);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
        }
    }
}
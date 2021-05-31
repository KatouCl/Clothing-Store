using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using KS.Entities;
using KS.Interfaces.DataAccess.Repositories;
using KS.ViewModels.Order;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using KS.WebAdmin.Models;

namespace KS.WebAdmin.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IBaseRepository<Order> _orderRepository;

        public HomeController(
            ILogger<HomeController> logger,
            IBaseRepository<Order> orderRepository)
        {
            _logger = logger;
            _orderRepository = orderRepository;
        }

        public IActionResult Index()
        {
            var ordersList = _orderRepository.GetAll()
                .Select(x => new OrderHomeViewModel
                {

                });
            
            return View(ordersList);
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
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using KS.Entities;
using KS.Interfaces.DataAccess.BusinessLogic.Services;
using KS.Interfaces.DataAccess.Repositories;
using KS.ViewModels.Cart;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace KS.WEB.Controllers
{
    public class CartController : Controller
    {
        private readonly IBaseRepository<CartItem> _cartRepository;
        private readonly ICartService _cartService;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ISession _session;

        public CartController(
            ICartService cartService,
            UserManager<ApplicationUser> userManager,
            IBaseRepository<CartItem> cartRepository,
            ISession session)
        {
            _cartService = cartService;
            _userManager = userManager;
            _cartRepository = cartRepository;
            _session = session;
        }

        public class Reqst
        {
            public int ProductId { get; set; }
            public int Quantity { get; set; }
        }

        public async Task<IActionResult> Index()
        {
            var currentUser = await _userManager.GetUserAsync(HttpContext.User);
            if (currentUser == null)
            {
                ViewBag["SM"] = "Вы не авторизованы";
                return RedirectToAction("Index", "Home");
            }

            var cartListProducts = _cartService.GetCartDetails(currentUser.Id);
            // var cartListProducts = _cartService.GetCartDetailsAsync(HttpContext.Session);

            return View(cartListProducts);
        }

        public async Task<IActionResult> AddToCart(int productId, int? quantity)
        {
            var currentUser = await _userManager.GetUserAsync(HttpContext.User);
            if (currentUser == null)
            {
                TempData["SM"] = "Вы не авторизованы";
                return RedirectToAction("Index", "Home");
            }
            
            var cartProduct = new CartItemVm
            {
                ProductId = productId,
                Quantity = quantity?? 1
            };

            var stringObject = JsonConvert.SerializeObject(cartProduct);
            _session.SetString("cart", stringObject);
            
            _cartService.AddToCart(HttpContext.Session, cartProduct);

            TempData["SM"] = "Товар добавлен";
            return RedirectToAction("Details", "Product", new {id = productId});
        }

        public async Task<IActionResult> RemoveFromCart(int id)
        {
            var currentUser = await _userManager.GetUserAsync(HttpContext.User);
            if (currentUser == null)
            {
                TempData["SM"] = "Вы не авторизованы";
                return RedirectToAction("Index", "Home");
            }

            var product = await _cartRepository.GetByIdAsync(id);

            await _cartRepository.DeleteAsync(product);
            TempData["SM"] = "Вы успешно удалили.";

            return RedirectToAction("Index", "Cart");
        }
    }
}
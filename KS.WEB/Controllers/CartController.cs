using System;
using System.Threading.Tasks;
using KS.Entities;
using KS.Interfaces.DataAccess.BusinessLogic.Services;
using KS.Interfaces.DataAccess.Repositories;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace KS.WEB.Controllers
{
    public class CartController : Controller
    {
        private readonly ICartService _cartService;
        private readonly UserManager<ApplicationUser> _userManager;

        public CartController(
            ICartService cartService, 
            UserManager<ApplicationUser> userManager)
        {
            _cartService = cartService;
            _userManager = userManager;
        }

        // GET
        public async Task<IActionResult> Index()
        {
            var currentUser = await _userManager.GetUserAsync(HttpContext.User);
            if (currentUser == null)
            {
                ViewBag.Message = "Вы не авторизованы";
                return RedirectToAction("Index", "Home");
            }
            var cartListProducts = _cartService.GetCartDetails(currentUser.Id);
            
            return View(cartListProducts);
        }
        public async Task<IActionResult> AddToCart(int productId, int? quantity)
        {
            var currentUser = await _userManager.GetUserAsync(HttpContext.User);
            if (currentUser == null)
            {
                ViewBag.Message = "Вы не авторизованы";
                return RedirectToAction("Index", "Home");
            }
            await _cartService.AddToCart(currentUser.Id, productId, quantity);

            ViewBag.Message = "Товар добавлен";
            return RedirectToAction("Details", "Product", new {productId});
        }
    }
}
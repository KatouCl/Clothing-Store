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
        private readonly IBaseRepository<Cart> _cartRepository;
        private readonly ICartService _cartService;
        private readonly UserManager<ApplicationUser> _userManager;

        public CartController(
            ICartService cartService, 
            UserManager<ApplicationUser> userManager,
            IBaseRepository<Cart> cartRepository)
        {
            _cartService = cartService;
            _userManager = userManager;
            _cartRepository = cartRepository;
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
            await _cartService.AddToCart(currentUser.Id, productId, quantity);

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
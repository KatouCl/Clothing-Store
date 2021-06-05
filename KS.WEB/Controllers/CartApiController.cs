using System;
using System.Threading.Tasks;
using KS.Entities;
using KS.Interfaces.DataAccess.BusinessLogic.Services;
using KS.Interfaces.DataAccess.Repositories;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace KS.WEB.Controllers
{
    public class CartApiController : Controller
    {
        private readonly ICartService _cartService;
        private readonly UserManager<ApplicationUser> _userManager;

        public CartApiController(
            ICartService cartService, 
            UserManager<ApplicationUser> userManager)
        {
            _cartService = cartService;
            _userManager = userManager;
        }

        // GET
        public async Task<IActionResult> List(long customerId)
        {
            var currentUser = await _userManager.GetUserAsync(HttpContext.User);
            var cart = await _cartService.GetActiveCartDetails(customerId, Convert.ToInt64(currentUser.Id));
             
            
            return View(cart);
        }
        public async Task<IActionResult> AddToCart(int productId)
        {
            var currentUser = await _userManager.GetUserAsync(HttpContext.User);
            // await _cartService.AddToCart(currentUser.Id,productId);

            return Accepted();
        }
    }
}
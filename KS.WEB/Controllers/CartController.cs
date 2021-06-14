using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KS.Entities;
using KS.Interfaces.DataAccess.BusinessLogic.Services;
using KS.Interfaces.DataAccess.Repositories;
using KS.ViewModels;
using KS.ViewModels.Cart;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace KS.WEB.Controllers
{
    public class CartController : Controller
    {
        private readonly IBaseRepository<CartItem> _cartRepository;
        private readonly IBaseRepository<Product> _productRepository;
        private readonly ICartService _cartService;
        private readonly UserManager<ApplicationUser> _userManager;

        public CartController(
            ICartService cartService,
            UserManager<ApplicationUser> userManager,
            IBaseRepository<CartItem> cartRepository,
            IBaseRepository<Product> productRepository)
        {
            _cartService = cartService;
            _userManager = userManager;
            _cartRepository = cartRepository;
            _productRepository = productRepository;
        }
        
        public async Task<IActionResult> Index()
        {
            var cartDetails = await _cartService.GetCartDetailsAsync(HttpContext.Session);
            return View(cartDetails);
        }

        [Authorize]
        public  IActionResult AddToCart(int productId, int? quantity)
        {
            var product = _productRepository.GetByIdAsync(productId).Result;
            var addProductToCart = new CartItemVm
            {
                Id = productId,
                ProductId = productId,
                ProductName = product.Name,
                Price = product.Price,
                ImageUrl = product.CoverImageUrl,
                Quantity = quantity?? 1
            };
            
            _cartService.AddProductToCart(HttpContext.Session, addProductToCart);
            
            TempData["SM"] = "Товар добавлен";
            return RedirectToAction("Details", "Product", new {id = productId});
        }

        [Authorize]
        public IActionResult RemoveFromCart(int id)
        {
            var removeProductFromCart = new CartItemVm { Id = id };
            _cartService.RemoveProductFromCart(HttpContext.Session, removeProductFromCart);

            TempData["SM"] = "Вы успешно удалили.";
            return RedirectToAction("Index", "Cart");
        }

        public IActionResult CheckoutOrder()
        {
            var cartDetails =  _cartService.GetCartDetailsAsync(HttpContext.Session);
            ViewBag.TotalPrice = cartDetails.Result.Price.ToString("0");
            
            return View();
        }
        
        [Authorize]
        public async Task<IActionResult> Checkout(CheckoutVm checkout)
        {
            var currentUser = await _userManager.GetUserAsync(HttpContext.User);
            await _cartService.Checkout(HttpContext.Session, checkout, currentUser);
            return View();
        }

        public IActionResult ClearCart()
        {
            _cartService.ClearProductFromCart(HttpContext.Session);
            return RedirectToAction("Index", "Cart");
        }
        public int GetCartQuantity()
        {
            var cartQuantity = _cartService.GetCartQuantity(HttpContext.Session);
            return cartQuantity;
        }
    }
}
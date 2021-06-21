using System.Linq;
using System.Threading.Tasks;
using KS.Entities;
using KS.Interfaces.DataAccess.BusinessLogic.Services;
using KS.Interfaces.DataAccess.Repositories;
using KS.ViewModels.Cart;
using KS.ViewModels.Checkout;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace KS.WEB.Controllers
{
    [Authorize]
    public class CartController : Controller
    {
        private readonly IBaseRepository<CartItem> _cartRepository;
        private readonly IBaseRepository<Stock> _stockRepository;
        private readonly IBaseRepository<Product> _productRepository;
        private readonly ICartService _cartService;
        private readonly UserManager<ApplicationUser> _userManager;
        private const string SessionKey = "CartProducts";

        public CartController(
            ICartService cartService,
            UserManager<ApplicationUser> userManager,
            IBaseRepository<CartItem> cartRepository,
            IBaseRepository<Product> productRepository,
            IBaseRepository<Stock> stockRepository)
        {
            _cartService = cartService;
            _userManager = userManager;
            _cartRepository = cartRepository;
            _productRepository = productRepository;
            _stockRepository = stockRepository;
        }

        public async Task<IActionResult> Index()
        {
            var cartDetails = await _cartService.GetCartDetailsAsync(HttpContext.Session);
            
            return View(cartDetails);
        }

        public IActionResult AddToCart(int productId, int? quantity, long stockId)
        {
            var product = _productRepository.GetByIdAsync(productId).Result;
            var addProductToCart = new CartItemVm
            {
                Id = productId,
                ProductId = productId,
                ProductName = product.Name,
                Price = product.Price,
                ImageUrl = product.CoverImageUrl,
                Quantity = quantity ?? 1,
                StockId = stockId
                
            };
            
            _cartService.AddProductToCart(HttpContext.Session, addProductToCart);

            return RedirectToAction("Details", "Product", new {id = productId});
        }

        public IActionResult RemoveFromCart(int id)
        {
            var removeProductFromCart = new CartItemVm {Id = id};
            _cartService.RemoveProductFromCart(HttpContext.Session, removeProductFromCart);

            TempData["SM"] = "Вы успешно удалили.";
            return RedirectToAction("Index", "Cart");
        }

        public IActionResult CheckoutOrder()
        {
            var cartDetails = _cartService.GetCartDetailsAsync(HttpContext.Session);
            if (!cartDetails.Result.Products.Any())
            {
                TempData["SM"] = "Корзина пуста.";
                return RedirectToAction("Index", "Cart");
            }

            foreach (var item in cartDetails.Result.Products)
            {
                var stock = _stockRepository.GetAll().FirstOrDefault(x =>
                    x.ProductId == item.ProductId && x.Id == item.StockId);
                if (stock.Quantity < item.Quantity)
                {
                    TempData["SM"] = $"Количество товара '{item.ProductName}' превышает количество, которое есть на складе {stock.Quantity} шт.";
                    return RedirectToAction("Index", "Cart");
                }
            }
            
            ViewBag.TotalPrice = cartDetails.Result.Products.Sum(x => x.Price * x.Quantity).ToString("0");
            return View();
        }

        public async Task<IActionResult> Checkout(CheckoutVm checkout)
        {
            if (ModelState.IsValid)
            {
                var currentUser = await _userManager.GetUserAsync(HttpContext.User);
                var result = await _cartService.Checkout(HttpContext.Session, checkout, currentUser);
                if (result == 0)
                {
                    TempData["SM"] = "Количество товаров превышает количество, которое есть на складе.";
                    return RedirectToAction("Index", "Cart");
                }
                return View();
            }

            return View(checkout);
        }

        public IActionResult ClearCart()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Cart");
        }
        public IActionResult UpdateIncrementToCart(int productId,long stockId)
        {
            var product = _productRepository.GetByIdAsync(productId).Result;
            var updateProductToCart = new CartItemVm
            {
                Id = productId,
                ProductId = productId,
                ProductName = product.Name,
                Price = product.Price,
                ImageUrl = product.CoverImageUrl,
                StockId = stockId
                
            };
            
            _cartService.UpdateIncrementToCart(HttpContext.Session, updateProductToCart);

            return RedirectToAction("Index", "Cart");
        }
        public IActionResult UpdateDecrementToCart(int productId, long stockId)
        {
            var product = _productRepository.GetByIdAsync(productId).Result;
            var updateProductToCart = new CartItemVm
            {
                Id = productId,
                ProductId = productId,
                ProductName = product.Name,
                Price = product.Price,
                ImageUrl = product.CoverImageUrl,
                StockId = stockId
                
            };
            
            _cartService.UpdateDecrementToCart(HttpContext.Session, updateProductToCart);

            return RedirectToAction("Index", "Cart");
        }

        [HttpGet]
        public int GetCartQuantity()
        {
            var cartQuantity = _cartService.GetCartQuantity(HttpContext.Session);
            return cartQuantity;
        }
    }
}
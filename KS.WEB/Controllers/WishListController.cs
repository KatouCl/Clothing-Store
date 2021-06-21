using System.Linq;
using System.Threading.Tasks;
using KS.Entities;
using KS.Interfaces.DataAccess.BusinessLogic.Services;
using KS.Interfaces.DataAccess.Repositories;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace KS.WEB.Controllers
{
    public class WishListController : Controller
    {
        private readonly IBaseRepository<WishList> _wishListRepository;
        private readonly IWishListService _wishListService;
        private readonly UserManager<ApplicationUser> _userManager;

        public WishListController(
            UserManager<ApplicationUser> userManager,
            IWishListService wishListService,
            IBaseRepository<WishList> wishListRepository)
        {
            _userManager = userManager;
            _wishListService = wishListService;
            _wishListRepository = wishListRepository;
        }

        public async Task<IActionResult> Index()
        {
            var currentUser = await _userManager.GetUserAsync(HttpContext.User);
            if (currentUser == null)
            {
                ViewBag["SM"] = "Вы не авторизованы";
                return RedirectToAction("Index", "Home");
            }
            var wishListProducts = _wishListService.GetWishListDetails(currentUser.Id);
            
            return View(wishListProducts);
        }
        
        public async Task<IActionResult> AddToWishList(int productId)
        {
            var currentUser = await _userManager.GetUserAsync(HttpContext.User);
            if (currentUser == null)
            {
                TempData["SM"] = "Вы не авторизованы";
                return RedirectToAction("Index", "Home");
            }
            await _wishListService.AddToWishList(currentUser.Id, productId);

            TempData["SM"] = "Товар добавлен";
            return RedirectToAction("Details", "Product", new {id = productId});
        }

        public async Task<IActionResult> RemoveFromWishList(int id)
        {
            var currentUser = await _userManager.GetUserAsync(HttpContext.User);
            if (currentUser == null)
            {
                TempData["SM"] = "Вы не авторизованы";
                return RedirectToAction("Index", "Home");
            }
            var product = await _wishListRepository.GetByIdAsync(id);
            
            await _wishListRepository.DeleteAsync(product);
            TempData["SM"] = "Вы успешно удалили.";

            return RedirectToAction("Index", "WishList");
        }
        
        [HttpGet]
        public int GetWishListQuantity()
        {
            var wishListQuantity = _wishListRepository.GetAllQuery().Select(x => x.ProductId).Count();
            return wishListQuantity;
        }
    }
}
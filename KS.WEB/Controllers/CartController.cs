using Microsoft.AspNetCore.Mvc;

namespace KS.WEB.Controllers
{
    public class CartController : Controller
    {
        // GET
        public IActionResult Index()
        {
            return View();
        }
    }
}
using Microsoft.AspNetCore.Mvc;

namespace KS.WEB.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class OrderController : Controller
    {
        // GET
        public IActionResult Index()
        {
            
            
            return View();
        }
    }
}
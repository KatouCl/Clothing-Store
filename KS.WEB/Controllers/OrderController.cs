using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace KS.WEB.Controllers
{
    [Authorize]
    public class OrderController : Controller
    {
        // GET
        public IActionResult OrderList()
        {
            return View();
        }
    }
}
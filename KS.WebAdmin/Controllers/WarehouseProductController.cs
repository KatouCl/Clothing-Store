using Microsoft.AspNetCore.Mvc;

namespace KS.WebAdmin.Controllers
{
    public class WarehouseProductController : Controller
    {

        public WarehouseProductController()
        {
            
        }
        
            // GET
        public IActionResult Index()
        {
            return View();
        }
    }
}
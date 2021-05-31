using System.Threading.Tasks;
using KS.Interfaces.DataAccess.BusinessLogic.Services;
using KS.ViewModels.Product;
using Microsoft.AspNetCore.Mvc;

namespace KS.WEB.Controllers
{
    public class CatalogController : Controller
    {
        private readonly ICategoryService _categoryServiceervice;

        public CatalogController(ICategoryService categoryService)
        {
            _categoryServiceervice = categoryService;
        }
        // GET
        public IActionResult Index()
        {
            var catalogListing = _categoryServiceervice.GetProductForCatalog();

            return View(catalogListing);
        }
        public IActionResult Woman()
        {
            var catalogListing = _categoryServiceervice.GetProductForFemale();

            return View(catalogListing);
        }
        public IActionResult Men()
        {
            var catalogListing = _categoryServiceervice.GetProductForMale();

            return View(catalogListing);
        }
    }
}
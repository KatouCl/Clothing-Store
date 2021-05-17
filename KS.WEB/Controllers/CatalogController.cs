using System.Threading.Tasks;
using KS.Interfaces.DataAccess.BusinessLogic.Services;
using KS.ViewModels.Product;
using Microsoft.AspNetCore.Mvc;

namespace KS.WEB.Controllers
{
    public class CatalogController : Controller
    {
        private readonly IProductService _productService;

        public CatalogController(IProductService productService)
        {
            _productService = productService;
        }
        // GET
        public IActionResult Index()
        {
            //var product = _productService.GetProductForCatalogAsync();

            //var model = new ProductListingViewModel
            //{
            //    Products = product
            //};

            return View();
        }
    }
}
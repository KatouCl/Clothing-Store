using System.Threading.Tasks;
using KS.Interfaces.DataAccess.BusinessLogic.Services;
using KS.Interfaces.DataAccess.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace KS.WEB.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        private readonly IProductRepository _productRepository;
            
        public ProductController(IProductService productService, IProductRepository productRepository)
        {
            _productService = productService;
            _productRepository = productRepository;
        }
        // GET
        public async Task<IActionResult> Details(int id)
        {
            var product = await _productService.GetProductDetailsByIdAsync(id);

            return View(product);
        }
    }
}
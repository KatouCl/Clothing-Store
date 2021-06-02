using System.Threading.Tasks;
using KS.Entities;
using KS.Interfaces.DataAccess.BusinessLogic.Services;
using KS.Interfaces.DataAccess.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace KS.WEB.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        private readonly IBaseRepository<Product> _productRepository;
            
        public ProductController(IProductService productService, IBaseRepository<Product> productRepository)
        {
            _productService = productService;
            _productRepository = productRepository;
        }
        // GET
        public async Task<IActionResult> Details(int id)
        {
            var product = await _productRepository.GetByIdAsync(id);
            

            return View(product);
        }
    }
}
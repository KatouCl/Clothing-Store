using System.Linq;
using System.Threading.Tasks;
using KS.BusinessLogic.Services;
using KS.Entities;
using KS.Interfaces.DataAccess.BusinessLogic.Services;
using KS.Interfaces.DataAccess.Repositories;
using KS.ViewModels.Cart;
using KS.ViewModels.Category;
using KS.ViewModels.Product;
using Microsoft.AspNetCore.Mvc;

namespace KS.WEB.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        private readonly IBaseRepository<Product> _productRepository;
        private readonly ICategoryService _categoryService;

        public ProductController(
            IProductService productService,
            IBaseRepository<Product> productRepository,
            ICategoryService categoryService)
        {
            _productService = productService;
            _productRepository = productRepository;
            _categoryService = categoryService;
        }

        // GET
        public IActionResult Details(int id, long? categoryId)
        {
            var product = _categoryService.GetProductForCatalog(categoryId)
                .FirstOrDefault(x => x.Id == id);
                
            var model = new GoodsInStockVm
            {
                Id = product.Id,
                Name = product.Name,
                Slug = product.Slug,
                ShortDescription = product.ShortDescription,
                Description = product.Description,
                Specification = product.Specification,
                OldPrice = product.OldPrice,
                Price = product.Price,
                SpecialPrice = product.SpecialPrice,
                SpecialPriceStart = product.SpecialPriceStart,
                SpecialPriceEnd = product.SpecialPriceEnd,
                IsFeatured = product.IsFeatured,
                IsCallForPricing = product.IsCallForPricing,
                IsAllowToOrder = product.IsAllowToOrder,
                CategoryIds = product.CategoryIds,
                BrandId = product.BrandId,
                TaxClassId = product.TaxClassId,
                StockTrackingIsEnabled = product.StockTrackingIsEnabled,
                CoverImageUrl = product.CoverImageUrl,
                GenderType = product.GenderType,
                UnitType = product.UnitType,
                QuantityStock = product.QuantityStock
            };

            return View(model);
        }
    }
}
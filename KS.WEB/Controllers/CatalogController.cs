using System.Linq;
using System.Threading.Tasks;
using KS.Interfaces.DataAccess.BusinessLogic.Services;
using KS.ViewModels.Product;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using X.PagedList;

namespace KS.WEB.Controllers
{
    public class CatalogController : Controller
    {
        private readonly ICategoryService _categoryService;

        public CatalogController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        // GET
        public IActionResult Index(int? page, long? categoryId)
        {
            var pageNumber = page ?? 1;

            var catalogListing = _categoryService.GetProductForCatalog(categoryId);

            var onePageOfCatalogs = catalogListing.ToPagedList(pageNumber, 9);
            ViewBag.onePageOfCatalogs = onePageOfCatalogs;
            
            return View(onePageOfCatalogs);
        }
        public IActionResult Woman(int? page, long? categoryId)
        {
            var catalogListing = _categoryService.GetProductForFemale(categoryId);

            var pageNumber = page ?? 1;

            var onePageOfCatalogWoman = catalogListing.ToPagedList(pageNumber, 9);
            ViewBag.onePageOfCatalogs = onePageOfCatalogWoman;
            
            return View(onePageOfCatalogWoman);
        }
        public IActionResult Men(int? page, long? categoryId)
        {
            var catalogListing = _categoryService.GetProductForMale(categoryId);

            var pageNumber = page ?? 1;
            
            var onePageOfCatalogMen = catalogListing.ToPagedList(pageNumber, 9);
            ViewBag.onePageOfCatalogs = onePageOfCatalogMen;
            
            return View(onePageOfCatalogMen);
        }
    }
}
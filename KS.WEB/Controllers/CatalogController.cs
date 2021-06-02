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
            
            var catalogListing = _categoryService.GetProductForCatalog()
                .Where(x => categoryId is null or 0 || x.CategoryIds.Contains(categoryId ?? 0));

            ViewBag.Categories = new SelectList(_categoryService.GetProductForCatalog()
                .Select(x => x.CategoryIds)
                .ToList(), "Id", "Name");
            
            ViewBag.SelectedCategory = categoryId.ToString();

            var onePageOfCatalogs = catalogListing.ToPagedList(pageNumber, 9);
            ViewBag.onePageOfCatalogs = onePageOfCatalogs;
            
            return View(onePageOfCatalogs);
        }
        public IActionResult Woman(int? page, long? categoryId)
        {
            var catalogListing = _categoryService.GetProductForFemale();

            var pageNumber = page ?? 1;

            ViewBag.Categories = new SelectList(_categoryService.GetProductForFemale()
                .Select(x => x.CategoryIds)
                .ToList(), "Id", "Name");
            
            ViewBag.SelectedCategory = categoryId.ToString();

            var onePageOfCatalogWoman = catalogListing.ToPagedList(pageNumber, 9);
            ViewBag.onePageOfCatalogs = onePageOfCatalogWoman;
            
            return View(onePageOfCatalogWoman);
        }
        public IActionResult Men(int? page, long? categoryId)
        {
            var catalogListing = _categoryService.GetProductForMale();

            var pageNumber = page ?? 1;
            
            ViewBag.Categories = new SelectList(_categoryService.GetProductForMale()
                .Select(x => x.CategoryIds)
                .ToList(), "Id", "Name");
            
            ViewBag.SelectedCategory = categoryId.ToString();

            var onePageOfCatalogMen = catalogListing.ToPagedList(pageNumber, 9);
            ViewBag.onePageOfCatalogs = onePageOfCatalogMen;
            
            return View(onePageOfCatalogMen);
        }
    }
}
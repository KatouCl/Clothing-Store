using System.Linq;
using JetBrains.Annotations;
using KS.Interfaces.DataAccess.BusinessLogic.Services;
using KS.ViewModels.Category;
using KS.ViewModels.Search;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KS.WEB.Controllers
{
    public class SearchController : Controller
    {
        private readonly ISearchService _searchService;

        public SearchController(ISearchService searchService)
        {
            _searchService = searchService;
        }

        public IActionResult Result(string searchQuery, long? categoryId)
        {
            var products = _searchService.SearchProduct(searchQuery, categoryId);

            var noResult =
                (!string.IsNullOrEmpty(searchQuery) && products.Any());

            var productListings = products.Select(x => new GoodsInStockVm
            {
                Id = x.Id,
                Name = x.Name,
                Slug = x.Slug,
                ShortDescription = x.ShortDescription,
                Description = x.Description,
                Specification = x.Specification,
                OldPrice = x.OldPrice,
                Price = x.Price,
                SpecialPrice = x.SpecialPrice,
                SpecialPriceStart = x.SpecialPriceStart,
                SpecialPriceEnd = x.SpecialPriceEnd,
                IsFeatured = x.IsFeatured,
                IsCallForPricing = x.IsCallForPricing,
                IsAllowToOrder = x.IsAllowToOrder,
                BrandId = x.BrandId,
                TaxClassId = x.TaxClassId,
                StockTrackingIsEnabled = x.StockTrackingIsEnabled,
                GenderType = x.GenderType,
                UnitType = x.UnitType,
                CategoryId = x.CategoryId,
                CoverImageUrl = x.CoverImageUrl
            });

            var model = new SearchResultVm
            {
                Products = productListings,
                SearchQuery = searchQuery,
                EmptySearchResults = noResult
            };

            return View(model);
        }

        public IActionResult Search(string searchQuery)
        {
            return RedirectToAction("Result", new {searchQuery});
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using KS.Interfaces.DataAccess.BusinessLogic.Services;
using KS.ViewModels.Category;

namespace KS.BusinessLogic.Services
{
    public class SearchService : ISearchService
    {
        private readonly ICategoryService _categoryService;

        public SearchService(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public IEnumerable<GoodsInStockVm> SearchProduct(string searchQuery, long? categoryId)
        {
            var normalized = searchQuery.ToLower();
            
            return _categoryService.GetProductForCatalog(categoryId).Where(product  
                => product.Name.ToLower().Contains(normalized)
                   || product.Price == Convert.ToDecimal(normalized)
                   || product.Slug.ToLower().Contains(normalized)
                   );
        }
    }
}
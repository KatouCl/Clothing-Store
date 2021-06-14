using System.Collections.Generic;
using KS.ViewModels.Category;

namespace KS.Interfaces.DataAccess.BusinessLogic.Services
{
    public interface ISearchService
    {
        IEnumerable<GoodsInStockVm> SearchProduct(string searchQuery, long? categoryId);
    }
}
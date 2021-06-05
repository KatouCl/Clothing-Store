using System.Collections.Generic;
using KS.ViewModels.Category;

namespace KS.Interfaces.DataAccess.BusinessLogic.Services
{
    public interface ICategoryService
    {
        IEnumerable<GoodsInStockVm> GetProductForCatalog(long? categoryId);
        IEnumerable<GoodsInStockVm> GetProductForMale(long? categoryId);
        IEnumerable<GoodsInStockVm> GetProductForFemale(long? categoryId);
    }
}
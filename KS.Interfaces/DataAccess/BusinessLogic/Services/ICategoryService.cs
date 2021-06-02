using System.Collections.Generic;
using KS.ViewModels.Category;

namespace KS.Interfaces.DataAccess.BusinessLogic.Services
{
    public interface ICategoryService
    {
        IEnumerable<CatalogViewModel> GetProductForCatalog(long? categoryId);
        IEnumerable<CategoryMaleViewModel> GetProductForMale(long? categoryId);
        IEnumerable<CategoryFemaleViewModel> GetProductForFemale(long? categoryId);
    }
}
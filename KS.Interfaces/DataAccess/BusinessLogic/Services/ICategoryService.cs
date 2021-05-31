using System.Collections.Generic;
using KS.ViewModels.Category;

namespace KS.Interfaces.DataAccess.BusinessLogic.Services
{
    public interface ICategoryService
    {
        IEnumerable<CatalogViewModel> GetProductForCatalog();
        IEnumerable<CategoryMaleViewModel> GetProductForMale();
        IEnumerable<CategoryFemaleViewModel> GetProductForFemale();
    }
}
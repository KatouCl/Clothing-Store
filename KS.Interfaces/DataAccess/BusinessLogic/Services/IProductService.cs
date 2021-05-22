using System.Collections.Generic;
using System.Threading.Tasks;
using KS.Entities;
using KS.ViewModels.Cart;
using KS.ViewModels.Product;
using ProductIndexViewModel = KS.ViewModels.Product.ProductIndexViewModel;

namespace KS.Interfaces.DataAccess.BusinessLogic.Services
{
    public interface IProductService
    {
        // IEnumerable<ProductCartViewModel> GetProductForMainPage();
        IEnumerable<ProductIndexViewModel> GetProductForCatalogAsync();
        Task<ProductIndexViewModel> GetProductDetailsByIdAsync(int id);
    }
}
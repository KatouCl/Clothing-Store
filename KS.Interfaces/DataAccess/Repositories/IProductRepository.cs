using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using KS.Entities;
using KS.ViewModels.Cart;

namespace KS.Interfaces.DataAccess.Repositories
{
    public interface IProductRepository : IBaseRepository<Product>
    {
        Task<List<CartItemVm>> GetProductsForCartAsync(IEnumerable<long> ids);
    }
}
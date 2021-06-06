using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KS.Entities;
using KS.ViewModels.Cart;

namespace KS.Interfaces.DataAccess.BusinessLogic.Services
{
    public interface ICartService
    {
        Task<bool> AddToCart(string customerId, int productId, int? quantity);
        IList<CartVm> GetCartDetails(string customerId);
    }
}
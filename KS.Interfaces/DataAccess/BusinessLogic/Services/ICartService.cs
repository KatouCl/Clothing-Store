using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KS.Entities;
using KS.ViewModels.Cart;

namespace KS.Interfaces.DataAccess.BusinessLogic.Services
{
    public interface ICartService
    {
        Task<Cart> AddToCart(long customerId, long createdById, long productId, int quantity);

        IEnumerable<Cart> Query();


        Task<Cart> GetActiveCart(string customerId, int productId);

        Task<CartVm> GetActiveCartDetails(long customerId);

        Task<CartVm> GetActiveCartDetails(long customerId, long createdById);

        Task MigrateCart(long fromUserId, long toUserId);

        Task UnlockCart(Cart cart);
    }
}
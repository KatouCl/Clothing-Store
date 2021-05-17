using System.Threading.Tasks;
using KS.ViewModels.Cart;
using Microsoft.AspNetCore.Http;

namespace KS.Interfaces.DataAccess.BusinessLogic.Services
{
    public interface ICartService
    {
        Task<ProductCartViewModel> GetCartDetailsAsync(ISession session);
        void AddProductToCart(ISession session, AddProductToCartViewModel addProductToCart);
        void RemoveProductFromCart(ISession session, RemoveProductFromCartViewModel removeProductFromCart);
        int GetCartQuantity(ISession session);
        Task<int> Checkout(ISession session, CheckoutViewModel checkout);

    }
}
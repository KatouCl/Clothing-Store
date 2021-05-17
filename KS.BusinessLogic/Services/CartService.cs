using System.Threading.Tasks;
using KS.Interfaces.DataAccess.BusinessLogic.Services;
using KS.ViewModels.Cart;
using Microsoft.AspNetCore.Http;

namespace KS.BusinessLogic.Services
{
    public class CartService : ICartService
    {
        public Task<ProductCartViewModel> GetCartDetailsAsync(ISession session)
        {
            throw new System.NotImplementedException();
        }

        public void AddProductToCart(ISession session, AddProductToCartViewModel addProductToCart)
        {
            throw new System.NotImplementedException();
        }

        public void RemoveProductFromCart(ISession session, RemoveProductFromCartViewModel removeProductFromCart)
        {
            throw new System.NotImplementedException();
        }

        public int GetCartQuantity(ISession session)
        {
            throw new System.NotImplementedException();
        }

        public Task<int> Checkout(ISession session, CheckoutViewModel checkout)
        {
            throw new System.NotImplementedException();
        }
    }
}
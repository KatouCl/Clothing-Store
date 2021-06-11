using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KS.Entities;
using KS.ViewModels;
using KS.ViewModels.Cart;
using Microsoft.AspNetCore.Http;

namespace KS.Interfaces.DataAccess.BusinessLogic.Services
{
    public interface ICartService
    {
        // Task<ProductCartVm> GetCartDetailsAsync(ISession session);
        void AddToCart(ISession session, CartItemVm addProductToCart);

        IList<CartItemVm> GetCartDetails(string customerId);
        // int GetCartQuantity(ISession session);
        // Task<int> Checkout(ISession session, CheckoutVm checkout);
    }
}
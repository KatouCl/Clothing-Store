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
        void AddProductToCart(ISession session, CartItemVm addProductToCart);
        void ClearProductFromCart(ISession session);
        Task<ProductCartVm> GetCartDetailsAsync(ISession session);
        void RemoveProductFromCart(ISession session, CartItemVm removeProductFromCart);
        int GetCartQuantity(ISession session);
        Task<int> Checkout(ISession session, CheckoutVm checkout, ApplicationUser customer);
    }
}
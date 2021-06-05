using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using KS.Entities;
using KS.Interfaces.DataAccess.BusinessLogic.Services;
using KS.Interfaces.DataAccess.Repositories;
using KS.ViewModels.Cart;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace KS.BusinessLogic.Services
{
    public class CartService : ICartService
    {
        private readonly IBaseRepository<Cart> _cartRepository;
        private readonly IBaseRepository<Product> _productRepository;
        private readonly bool _isProductPriceIncludeTax;
        private readonly UserManager<ApplicationUser> _userManager;

        public CartService(
            IBaseRepository<Cart> cartRepository,
            bool isProductPriceIncludeTax,
            UserManager<ApplicationUser> userManager,
            IBaseRepository<Product> productRepository)
        {
            _cartRepository = cartRepository;
            _isProductPriceIncludeTax = isProductPriceIncludeTax;
            _userManager = userManager;
            _productRepository = productRepository;
        }

        public Task<Cart> AddToCart(long customerId, long createdById, long productId, int quantity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Cart> Query()
        {
            throw new NotImplementedException();
        }

        public Task<Cart> GetActiveCart(string customerId, int productId)
        {
            throw new NotImplementedException();
        }

        public Task<CartVm> GetActiveCartDetails(long customerId)
        {
            throw new NotImplementedException();
        }

        public Task<CartVm> GetActiveCartDetails(long customerId, long createdById)
        {
            throw new NotImplementedException();
        }

        public Task MigrateCart(long fromUserId, long toUserId)
        {
            throw new NotImplementedException();
        }

        public Task UnlockCart(Cart cart)
        {
            throw new NotImplementedException();
        }
    }
}
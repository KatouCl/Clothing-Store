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
        private readonly UserManager<ApplicationUser> _userManager;

        public CartService(
            IBaseRepository<Cart> cartRepository,
            UserManager<ApplicationUser> userManager,
            IBaseRepository<Product> productRepository)
        {
            _cartRepository = cartRepository;
            _userManager = userManager;
            _productRepository = productRepository;
        }

        public async Task<Cart> AddToCart(string customerId, int productId, int? quantity)
        {
            var product = _productRepository.GetByIdAsync(productId).Result;
            var productInCart = _cartRepository.GetAllQuery().FirstOrDefault(x => x.ProductId == productId);

            if (productInCart == null)
            {
                var model = new Cart
                {
                    CustomerId = customerId,
                    ProductId = product.Id,
                    Quantity = quantity ?? 1,
                    Price = product.Price
                };
                await _cartRepository.AddAsync(model);
            }
            else
            {
                productInCart.Quantity++;
            }

            await _cartRepository.SaveChangesAsync();
            return productInCart;
        }

        public IList<CartVm> GetCartDetails(string customerId)
        {
            var cartListProducts = _cartRepository.GetAll()
                .Where(x => x.CustomerId == customerId)
                .Select(x => new CartVm
                {
                    Id = x.Id,
                    CustomerId = x.CustomerId,
                    ProductId = x.ProductId,
                    Price = x.Price,
                    Quantity = x.Quantity,
                    
                    ImageUrl = _productRepository.GetByIdAsync(x.ProductId).Result.CoverImageUrl,
                    ProductName = _productRepository.GetByIdAsync(x.ProductId).Result.Name
                }).ToList();
            
            return cartListProducts;
        }
    }
}
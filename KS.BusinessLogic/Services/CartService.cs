using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KS.DataAccess;
using KS.Entities;
using KS.Interfaces.DataAccess.BusinessLogic.Services;
using KS.Interfaces.DataAccess.Repositories;
using KS.ViewModels;
using KS.ViewModels.Cart;
using KS.ViewModels.Session;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;

namespace KS.BusinessLogic.Services
{
    public class CartService : ICartService
    {
        private readonly IBaseRepository<CartItem> _cartRepository;
        private readonly IStockService _stockService;
        private readonly IBaseRepository<Product> _productRepository;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IHttpContextAccessor _contextAccessor;
        private const string SessionKey = "CartProducts";
        private readonly ISession _session;

        public CartService(
            IBaseRepository<CartItem> cartRepository,
            UserManager<ApplicationUser> userManager,
            IBaseRepository<Product> productRepository,
            IStockService stockService, 
            IHttpContextAccessor contextAccessor, 
            ISession session)
        {
            _cartRepository = cartRepository;
            _userManager = userManager;
            _productRepository = productRepository;
            _stockService = stockService;
            _contextAccessor = contextAccessor;
            _session = session;
        }

        public void AddToCart(ISession session, CartItemVm addProductToCart)
        {
            
        }


        public IList<CartItemVm> GetCartDetails(string customerId)
        {
            var cartListProducts = _cartRepository.GetAll()
                .Where(x => x.CustomerId == customerId)
                .Select(x => new CartItemVm
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
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
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;

namespace KS.BusinessLogic.Services
{
    public class CartService : ICartService
    {
        private readonly IBaseRepository<CartItem> _cartRepository;
        private readonly IStockService _stockService;
        private readonly IProductRepository _productRepository;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IBaseRepository<Order> _orderRepository;

        private const string SessionKey = "CartProducts";

        public CartService(
            IBaseRepository<CartItem> cartRepository,
            UserManager<ApplicationUser> userManager,
            IProductRepository productRepository,
            IStockService stockService,
            IBaseRepository<Order> orderRepository)
        {
            _cartRepository = cartRepository;
            _userManager = userManager;
            _productRepository = productRepository;
            _stockService = stockService;
            _orderRepository = orderRepository;
        }


        public void AddProductToCart(ISession session, CartItemVm addProductToCart)
        {
            var sessionData = this.GetSessionCartData(session);

            var existProduct = sessionData.Products.FirstOrDefault(x => x.ProductId == addProductToCart.ProductId);

            if (existProduct != default)
            {
                existProduct.Quantity++;
            }
            else
            {
                sessionData.Products.Add(new CartDetailsItemSessionVm
                {
                    Id = addProductToCart.Id,
                    ProductId = addProductToCart.ProductId,
                    ProductName = addProductToCart.ProductName,
                    ImageUrl = addProductToCart.ImageUrl,
                    Quantity = addProductToCart.Quantity,
                    Price = addProductToCart.Price
                });
            }

            this.SaveSessionCartData(session, sessionData);
        }

        public void ClearProductFromCart(ISession session)
        {
            this.ClearProductFromCart(session);
        }

        public async Task<ProductCartVm> GetCartDetailsAsync(ISession session)
        {
            var sessionData = this.GetSessionCartData(session);

            var result = new ProductCartVm();

            if (!sessionData.Products.Any())
            {
                return result;
            }

            var ids = sessionData.Products.Select(x => x.Id);

            var products = await _productRepository.GetProductsForCartAsync(ids);

            result.Products = sessionData.Products
                .Select(x => new CartItemVm
                {
                    Id = x.Id,
                    ProductName = x.ProductName,
                    ProductId = x.ProductId,
                    ImageUrl = x.ImageUrl,
                    Price = x.Price,
                    Quantity = x.Quantity
                }).ToList();

            return result;
        }

        public void RemoveProductFromCart(ISession session, CartItemVm removeProductFromCart)
        {
            var sessionData = this.GetSessionCartData(session);

            var removeItem = sessionData.Products.FirstOrDefault(x => x.Id == removeProductFromCart.Id);

            sessionData.Products.Remove(removeItem);

            this.SaveSessionCartData(session, sessionData);
        }

        public async Task<int> Checkout(ISession session, CheckoutVm checkout, ApplicationUser customer)
        {
            var sessionData = this.GetSessionCartData(session);
            
            var ids = sessionData.Products.Select(x => x.Id);

            var products = await _productRepository.GetAllQuery().Where(x => ids.Contains(x.Id)).ToListAsync();
            
            var order = new Order();
            
            var orderItems = new List<OrderItem>();
            
            foreach (var sessionProduct in sessionData.Products)
            {
                var product = products.FirstOrDefault(x => x.Id == sessionProduct.Id);
            
                var orderItem = orderItems.FirstOrDefault(x => x.Product.Id == product.Id);
            
                if (orderItem == default)
                {
                    orderItem = new OrderItem
                    {
                        Product = product,
                        Order = order,
                        Price = product.Price
                    };
            
                    orderItems.Add(orderItem);
                }
            }
            
            var delivery = new Delivery
            {
                FirstName = checkout.FirstName,
                LastName = checkout.LastName,
                City = checkout.City,
                Region = checkout.Region,
                Address = checkout.Address,
                Email = checkout.Email,
                Phone = checkout.Phone,
                Comment = checkout.Comment
            };
            
            order.OrderItems = orderItems;
            order.Delivery = delivery;
            order.Customer = customer;
            order.Price = order.OrderItems.Sum(x => x.TotalPrice);
            
            var checkoutId = (await _orderRepository.AddAsync(order)).Id;
            
            order.Id = checkoutId;
            
            this.ClearSessionCartData(session);
            
            return 1;
        }

        private CartDetailsSessionVm GetSessionCartData(ISession session)
        {
            var sessionDataString = session.GetString(SessionKey);

            CartDetailsSessionVm sessionData;

            if (sessionDataString == default)
            {
                sessionData = new CartDetailsSessionVm();
            }
            else
            {
                sessionData = JsonConvert.DeserializeObject<CartDetailsSessionVm>(sessionDataString);
            }

            return sessionData;
        }

        public int GetCartQuantity(ISession session)
        {
            var sessionData = this.GetSessionCartData(session);

            var quantity = sessionData.Products.Sum(x => x.Quantity);
            return quantity;
        }

        private void SaveSessionCartData(ISession session, CartDetailsSessionVm data)
            => session.SetString(SessionKey, JsonConvert.SerializeObject(data));

        private void ClearSessionCartData(ISession session)
            => session.Remove(SessionKey);
    }
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KS.DataAccess;
using KS.Entities;
using KS.Interfaces.DataAccess.BusinessLogic.Services;
using KS.Interfaces.DataAccess.Repositories;
using KS.ViewModels;
using KS.ViewModels.Cart;
using KS.ViewModels.Checkout;
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
        private readonly IBaseRepository<Stock> _stockRepository;
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
            IBaseRepository<Order> orderRepository,
            IBaseRepository<Stock> stockRepository)
        {
            _cartRepository = cartRepository;
            _userManager = userManager;
            _productRepository = productRepository;
            _stockService = stockService;
            _orderRepository = orderRepository;
            _stockRepository = stockRepository;
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
                    Price = addProductToCart.Price,
                    StockId = addProductToCart.StockId
                });
            }

            this.SaveSessionCartData(session, sessionData);
        }

        public void UpdateIncrementToCart(ISession session, CartItemVm addProductToCart)
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
                    Price = addProductToCart.Price,
                    StockId = addProductToCart.StockId
                });
            }

            this.SaveSessionCartData(session, sessionData);
        }

        public void UpdateDecrementToCart(ISession session, CartItemVm addProductToCart)
        {
            var sessionData = this.GetSessionCartData(session);

            var existProduct = sessionData.Products.FirstOrDefault(x => x.ProductId == addProductToCart.ProductId);

            if (existProduct != default)
            {
                existProduct.Quantity--;
                if (existProduct.Quantity == 0)
                {
                    existProduct.Quantity++;
                }
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
                    Price = addProductToCart.Price,
                    StockId = addProductToCart.StockId
                });
            }

            this.SaveSessionCartData(session, sessionData);
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
                    Quantity = x.Quantity,
                    StockId = x.StockId
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

            var item = sessionData.Products.Select(x => new CartDetailsItemSessionVm
                {
                    Id = x.Id,
                    ProductId = x.ProductId,
                    Price = x.Price,
                    Quantity = x.Quantity,
                    StockId = x.StockId
                })
                .Where(w => _stockRepository.GetByIdAsync(w.StockId).Result.Id == w.StockId
                            && _stockRepository.GetByIdAsync(w.StockId).Result.ProductId == w.ProductId
                            && _stockRepository.GetByIdAsync(w.StockId).Result.Quantity >= w.Quantity
                );

            var ids = sessionData.Products.Select(x => x.Id);
            if (item.Count() != ids.Count())
            {
                return 0;
            }

            var productIds = sessionData.Products.Select(x => x.ProductId);
            var products = await _productRepository.GetAllQuery().Where(x => productIds.Contains(x.Id)).ToListAsync();

            var order = new Order();

            var orderItems = new List<OrderItem>();

            foreach (var sessionProduct in sessionData.Products)
            {
                var product = products.FirstOrDefault(x => x.Id == sessionProduct.Id);

                var orderItem = orderItems.FirstOrDefault(x => x.Product.Id == product.Id);

                if (orderItem != default) continue;
                {
                    if (product != null)
                    {
                        orderItem = new OrderItem
                        {
                            Product = product,
                            Order = order,
                            Quantity = item.FirstOrDefault(x => x.ProductId == product.Id).Quantity,
                            Price = item.FirstOrDefault(x => x.ProductId == product.Id).Price,
                            TotalPrice = product.Price * item.FirstOrDefault(x => x.ProductId == product.Id).Quantity,
                        };

                        var stockQuantity = item.FirstOrDefault(x => x.ProductId == product.Id).StockId;

                        var stock = _stockRepository.GetAll().FirstOrDefault(x =>
                            x.ProductId == product.Id && x.Id == stockQuantity);

                        if (!(stock.Quantity >= 1))
                        {
                            await _stockRepository.DeleteAsync(stock);
                            return 0;
                        }
                        else
                        {
                            stock.Quantity = stock.Quantity - orderItem.Quantity;
                            await _stockRepository.UpdateAsync(stock);
                        }
                    }

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

            sessionData = sessionDataString == default ? new CartDetailsSessionVm() : JsonConvert.DeserializeObject<CartDetailsSessionVm>(sessionDataString);

            return sessionData;
        }

        public long GetCartQuantity(ISession session)
        {
            var sessionData = this.GetSessionCartData(session);

            var quantity = sessionData.Products.Count;
            return quantity;
        }

        private void SaveSessionCartData(ISession session, CartDetailsSessionVm data)
            => session.SetString(SessionKey, JsonConvert.SerializeObject(data));

        private void ClearSessionCartData(ISession session)
            => session.Remove(SessionKey);
    }
}
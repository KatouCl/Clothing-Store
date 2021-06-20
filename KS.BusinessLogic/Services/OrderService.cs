using System.Collections.Generic;
using System.Linq;
using KS.Entities;
using KS.Interfaces.DataAccess.BusinessLogic.Services;
using KS.Interfaces.DataAccess.Repositories;
using KS.ViewModels.Order;
using Microsoft.EntityFrameworkCore;

namespace KS.BusinessLogic.Services
{
    public class OrderService : IOrderService
    {
        private readonly IBaseRepository<Order> _orderRepository;
        private readonly IBaseRepository<OrderItem> _orderItemRepository;
        private readonly IBaseRepository<Product> _productRepository;

        public OrderService(IBaseRepository<Order> orderRepository,
            IBaseRepository<OrderItem> orderItemRepository, 
            IBaseRepository<Product> productRepository)
        {
            _orderRepository = orderRepository;
            _orderItemRepository = orderItemRepository;
            _productRepository = productRepository;
        }

        public IEnumerable<OrderListVm> GetOrderFromUser(string customerId)
        {
            var orderList = _orderRepository.GetAllQuery()
                .Where(x => x.Customer.Id == customerId)
                .Select(x => new OrderListVm
                {
                    Id = x.Id,
                    Customer = x.Customer.Id,
                    Price = x.Price,
                    CreationDate = x.CreationDate,
                    QuantityProduct = _orderItemRepository.GetAllQuery().Where(w => w.Order.Id == x.Id).Sum(s => s.Quantity)
                }).ToList();
            
            return orderList;
        }

        public IEnumerable<OrderListVm> GetOrders()
        {
            var orderList = _orderRepository.GetAllQuery()
                .Select(x => new OrderListVm
                {
                    Id = x.Id,
                    Customer = x.Customer.Id,
                    Price = x.Price,
                    CreationDate = x.CreationDate,
                    QuantityProduct = _orderItemRepository.GetAllQuery()
                        .Where(w => w.Order.Id == x.Id)
                        .Sum(s => s.Quantity)
                }).ToList();

            return orderList;
        }


        public IEnumerable<OrderDetailsItemVm> GetOrderDetailsItem(string customerId, long orderId)
        {
            var orderDetailsList = _orderItemRepository.GetAllQuery()
                .Where(x => x.Order.Id == orderId)
                .Select(x => new OrderDetailsItemVm
                {
                    Id = x.Id,
                    ProductId = x.Product.Id,
                    ProductName = _productRepository.GetAll().FirstOrDefault(p => p.Id == x.Product.Id).Name,
                    CoverImageUrl =_productRepository.GetAll().FirstOrDefault(p => p.Id == x.Product.Id).CoverImageUrl,
                    OrderId = orderId,
                    Quantity = x.Quantity,
                    Price = x.Price,
                    TotalPrice = x.Price * x.Quantity,
                    CreationDate = x.CreationDate
                });
            
            return orderDetailsList;
        }

        public IEnumerable<OrderDetailsItemVm> GetOrderDetails(long orderId)
        {
            var orderDetailsList = _orderItemRepository.GetAllQuery()
                .OrderBy(x => x.CreationDate)
                .Where(x => x.Order.Id == orderId)
                .Select(x => new OrderDetailsItemVm
                {
                    Id = x.Id,
                    ProductId = x.Product.Id,
                    ProductName = _productRepository.GetAll().FirstOrDefault(p => p.Id == x.Product.Id).Name,
                    CoverImageUrl =_productRepository.GetAll().FirstOrDefault(p => p.Id == x.Product.Id).CoverImageUrl,
                    OrderId = orderId,
                    Quantity = x.Quantity,
                    Price = x.Price,
                    TotalPrice = x.Price * x.Quantity,
                    CreationDate = x.CreationDate
                });
            
            return orderDetailsList;
        }
    }
}
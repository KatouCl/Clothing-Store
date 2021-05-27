using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KS.DataAccess;
using KS.Entities;
using KS.Interfaces.DataAccess.BusinessLogic.Services;
using KS.Interfaces.DataAccess.Repositories;
using KS.ViewModels.Stock;
using Microsoft.EntityFrameworkCore;

namespace KS.BusinessLogic.Services
{
    public class StockService : IStockService
    {
        private readonly IBaseRepository<Stock> _stockRepository;
        private readonly IBaseRepository<Product> _productRepository;
        private readonly IBaseRepository<StockHistory> _stockHistoryRepository;

        public StockService(IBaseRepository<Stock> stockService,
            IBaseRepository<Product> productRepository,
            IBaseRepository<StockHistory> stockHistoryRepository)
        {
            _stockRepository = stockService;
            _productRepository = productRepository;
            _stockHistoryRepository = stockHistoryRepository;
        }
        
        public async Task UpdateStock(StockUpdateViewModel stockUpdateVM)
        {
            var product = _productRepository.GetAll().FirstOrDefault(x => x.Id == stockUpdateVM.ProductId);
            var stock = _stockRepository.GetAll().FirstOrDefault(x =>
                x.ProductId == stockUpdateVM.ProductId && x.WarehouseId == stockUpdateVM.WarehouseId);

            stock.Quantity = stock.Quantity + stockUpdateVM.AdjustedQuantity;
            product.StockQuantity = product.StockQuantity + stockUpdateVM.AdjustedQuantity;
            
            var stockHistory = new StockHistory
            {
                ProductId = stockUpdateVM.ProductId,
                WarehouseId = stockUpdateVM.WarehouseId,
                AdjustedQuantity = stockUpdateVM.AdjustedQuantity,
            };

            await _stockHistoryRepository.AddAsync(stockHistory);
        }
    }
}
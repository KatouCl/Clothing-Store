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

        public StockService(IBaseRepository<Stock> stockService,
            IBaseRepository<Product> productRepository)
        {
            _stockRepository = stockService;
            _productRepository = productRepository;
        }
        
        // public async Task UpdateStock(StockUpdateViewModel stockUpdateVm)
        // {
        //     var product = _productRepository.GetAll().FirstOrDefault(x => x.Id == stockUpdateVm.ProductId);
        //     var stock = _stockRepository.GetAll().FirstOrDefault(x =>
        //         x.ProductId == stockUpdateVm.ProductId && x.WarehouseId == stockUpdateVm.WarehouseId);
        //
        //     stock.Quantity = stock.Quantity + stockUpdateVm.AdjustedQuantity;
        //     product.StockQuantity = product.StockQuantity + stockUpdateVm.AdjustedQuantity;
        //     
        //     var stock = new Stock
        //     {
        //         ProductId = stockUpdateVm.ProductId,
        //         WarehouseId = stockUpdateVm.WarehouseId,
        //         AdjustedQuantity = stockUpdateVm.AdjustedQuantity,
        //     };
        //
        //     await _stockRepository.AddAsync(stock);
        // }
    }
}
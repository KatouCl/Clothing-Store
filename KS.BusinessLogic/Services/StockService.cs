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
        
        public async Task UpdateStock(StockUpdateVm stockUpdateVm)
        {
            var product = _productRepository.GetAll().FirstOrDefault(x => x.Id == stockUpdateVm.ProductId);
            var stock = _stockRepository.GetAll().FirstOrDefault(x =>
                x.ProductId == stockUpdateVm.ProductId && x.WarehouseId == stockUpdateVm.WarehouseId);
        
            stock.Quantity += stockUpdateVm.Quantity;
            if (stock.Quantity < 0)
            {
                stock.Quantity = 1;
                // await _stockRepository.DeleteAsync(stock);
            }
        
            await _stockRepository.UpdateAsync(stock);
        }
    }
}
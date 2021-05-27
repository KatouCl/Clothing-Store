using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KS.Entities;
using KS.Interfaces.DataAccess.BusinessLogic.Services;
using KS.Interfaces.DataAccess.Repositories;
using KS.ViewModels.Warehouse;
using Microsoft.AspNetCore.Mvc;

namespace KS.WebAdmin.Controllers
{
    public class WarehouseProductController : Controller
    {
        private readonly IBaseRepository<Warehouse> _warehouseRepository;
        private readonly IBaseRepository<Product> _productRepository;
        private readonly IBaseRepository<Stock> _stockRepository;
        private readonly IStockService _stockService;
        

        public WarehouseProductController(
            IBaseRepository<Warehouse> warehouseRepository,
            IBaseRepository<Product> productRepository,
            IBaseRepository<Stock> stockRepository,
            IStockService stockService
            )
        {
            _warehouseRepository = warehouseRepository;
            _productRepository = productRepository;
            _stockRepository = stockRepository;
            _stockService = stockService;
        }

        // GET
        public IActionResult GetProducts(int warehouseId)
        {
            var warehouse = _warehouseRepository.GetByIdAsync(warehouseId);
            ViewBag.warehouseId = warehouseId;

            var query = _productRepository
                .GetAll()
                .Where(x => !x.HasOptions);
            
            var joinedQuery = query.GroupJoin
                (
                    _stockRepository.GetAll().Where(x => x.WarehouseId == warehouseId),
                    product => product.Id, stock => stock.ProductId,
                    (product, stock) => new { product, stock }
                )
                .SelectMany(x => x.stock.DefaultIfEmpty(), (x, stock) => new MangeWarehouseProductItemViewModel
                {
                    Id = x.product.Id,
                    Name = x.product.Name
                    // Quantity = stock.Quantity
                }).ToList();

            return View(joinedQuery);
        }

        public async Task<IActionResult> AddProducts(int warehouseId, IList<MangeWarehouseProductItemViewModel> productIds)
        {
            var productIdsArray = productIds.Where(x => x.IsExistInWarehouse == true)
                .Select(x => x.Id).ToArray();

            var existedProductIds = _stockService.CheckListProduct(warehouseId, productIdsArray)
                .Select(x => x.ProductId).ToList();
            
            foreach(var id in existedProductIds)
            {
                productIds.RemoveAt(id);
            }
            
            var stocks = productIdsArray.Select(x => new Stock
            {
                ProductId = x,
                WarehouseId = warehouseId,
                Quantity = 0
            });
            
            await _stockRepository.AddRangeAsync(stocks);

            ViewBag.listProruct = stocks.ToList();
            return RedirectToAction("Storage", "Warehouse");
        }
    }
}
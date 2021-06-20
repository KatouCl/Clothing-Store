using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KS.Entities;
using KS.Interfaces.DataAccess.BusinessLogic.Services;
using KS.Interfaces.DataAccess.Repositories;
using KS.ViewModels.Stock;
using KS.ViewModels.Warehouse;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace KS.WEB.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles="Admin")]
    public class WarehouseProductController : Controller
    {
        private readonly IBaseRepository<Warehouse> _warehouseRepository;
        private readonly IBaseRepository<Product> _productRepository;
        private readonly IStockService _stockService;
        private readonly IBaseRepository<Stock> _stockRepository;


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
            ViewBag.warehouseId = warehouseId;

            var query = _productRepository
                .GetAll()
                .Where(x => !x.HasOptions);

            var stocksList = _stockRepository.GetAll()
                .Where(x => x.WarehouseId == warehouseId)
                .Select(x => new Stock
                {
                    Id = x.Id,
                    Product = _productRepository.GetByIdAsync(x.ProductId).Result,
                    Warehouse = _warehouseRepository.GetByIdAsync(x.WarehouseId).Result,
                    WarehouseId = x.WarehouseId,
                    ProductId = x.ProductId,
                    Quantity = x.Quantity
                });

            var joinedQuery = query.GroupJoin
                (
                    stocksList,
                    product => product.Id,
                    stock => stock.ProductId,
                    (product, stock) => new {product, stock}
                )
                .SelectMany(x => x.stock.DefaultIfEmpty(),
                    (x, stock) => new MangeWarehouseProductItemViewModel
                    {
                        Id = x.product.Id,
                        ProductId = x.product.Id,
                        Name = x.product.Name,
                        Quantity = stock?.Quantity ?? 0,
                    }).ToList();

            return View(joinedQuery);
        }

        public async Task<IActionResult> AddProducts(int warehouseId,
            IList<MangeWarehouseProductItemViewModel> productIds)
        {
            try
            {
                var productIdsArray = productIds.Where(x => x.isChech == true)
                    .Select(x => x.Id).ToArray();

                var existedProductIds = _stockRepository.GetAll()
                    .Where(x => x.WarehouseId == warehouseId && productIdsArray.Contains(x.ProductId))
                    .Select(x => x.ProductId).ToList();

                foreach (var id in existedProductIds)
                {
                    productIds.RemoveAt(Convert.ToInt32(id));
                }

                var stocks = productIdsArray.Select(x => new Stock
                {
                    ProductId = x,
                    WarehouseId = warehouseId,
                    Quantity = 1
                });

                await _stockRepository.AddRangeAsync(stocks);
                TempData["SM"] = "Товары добавлены";
            }
            catch (Exception e)
            {
                TempData["SM"] = $"{e.Message}";
                return RedirectToAction("GetProducts", "WarehouseProduct", new {warehouseId});
            }

            return RedirectToAction("Storage", "Warehouse");
        }

        public async Task<IActionResult> UpdateQuantityProduct(long warehouseId, long productId, int quantity)
        {
            var stockUpdateVm = new StockUpdateVm
            {
                WarehouseId = warehouseId,
                ProductId = productId,
                Quantity = quantity
            };
            await _stockService.UpdateStock(stockUpdateVm);
            return RedirectToAction("Stocks", "Warehouse", new {warehouseId = warehouseId});
        }

        public async Task<IActionResult> DeleteProductFromStock(long stockId, long warehouseId)
        {
            await _stockRepository.DeleteAsync(new Stock {Id = stockId});
            return RedirectToAction("Stocks", "Warehouse", new {warehouseId = warehouseId});
        }
    }
}
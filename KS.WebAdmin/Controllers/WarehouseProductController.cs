using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KS.Entities;
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

        public WarehouseProductController(
            IBaseRepository<Warehouse> warehouseRepository,
            IBaseRepository<Product> productRepository,
            IBaseRepository<Stock> stockRepository)
        {
            _warehouseRepository = warehouseRepository;
            _productRepository = productRepository;
            _stockRepository = stockRepository;
        }

        // GET
        public async Task<IActionResult> GetProducts(int warehouseId)
        {
            var warehouse = _warehouseRepository.GetByIdAsync(warehouseId);
            ViewBag.warehouseId = warehouseId;
            var stock = _stockRepository.GetAll().Where(x => x.WarehouseId == warehouseId)
                .Select(x => x.Quantity);

            var query = _productRepository.GetAll()
                .Where(x => !x.HasOptions)
                .Select(x => new MangeWarehouseProductItemViewModel
                {
                    Id = x.Id,
                    Name = x.Name,
                    IsCheck = x.HasOptions
                }).ToList();

            return View(query);
        }

        public async Task<IActionResult> AddProducts(int warehouseId, IList<MangeWarehouseProductItemViewModel> productIds)
        {
            var productIdsArray = productIds.Select(x => x.Id).ToArray();
            
            // var existedProductIds = _stockRepository.GetAll().FirstOrDefault(x => x.WarehouseId == warehouseId);
                // .Where(x => x.WarehouseId == warehouseId && productIdsArray.Contains(x.ProductId)).ToList();
                // .Select(x => x.ProductId).ToList();
            
            // foreach(var id in existedProductIds)
            // {
            //     productIds.RemoveAt(id);
            // }

            var stocks = productIdsArray.Select(x => new Stock
            {
                ProductId = x,
                WarehouseId = warehouseId,
                Quantity = 0
            });

            await _stockRepository.AddRangeAsync(stocks);
            
            return RedirectToAction();
        }
    }
}
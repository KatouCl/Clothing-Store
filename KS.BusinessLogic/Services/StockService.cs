using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KS.DataAccess;
using KS.Entities;
using KS.Interfaces.DataAccess.BusinessLogic.Services;
using KS.Interfaces.DataAccess.Repositories;
using Microsoft.EntityFrameworkCore;

namespace KS.BusinessLogic.Services
{
    public class StockService : IStockService
    {
        private readonly IStockRepository _stockRepository;
        private readonly ApplicationDbContext _context;

        public StockService(IStockRepository stockService,
            ApplicationDbContext context)
        {
            _stockRepository = stockService;
            _context = context;
        }
        
        public IList<Stock> CheckListProduct(int warehouseId, int[] productsIds)
        {
            // _stockRepository.GetAll() 
            return _context.Stocks
                .Where(x => x.WarehouseId == warehouseId && productsIds.Contains(x.ProductId)).ToList();
        }
    }
}
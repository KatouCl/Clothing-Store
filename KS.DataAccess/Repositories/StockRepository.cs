using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KS.Entities;
using KS.Interfaces.DataAccess.Repositories;
using KS.ViewModels.Brand;
using KS.ViewModels.Stock;
using Microsoft.EntityFrameworkCore;

namespace KS.DataAccess.Repositories
{
    public class StockRepository : BaseRepository<Product>, IStockRepository
    {
        
        private readonly ApplicationDbContext _context;
        public StockRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IList<StockIndexViewModel>> GetStock()
        {
        return await _context.Stocks.Select(x => new StockIndexViewModel
        {
            Id = x.Id,
            ProductId = x.ProductId,
            WarehouseId = x.WarehouseId
        }).ToListAsync();
        }
    }
}
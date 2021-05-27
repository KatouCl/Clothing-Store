using System.Collections.Generic;
using System.Threading.Tasks;
using KS.Entities;
using KS.ViewModels.Stock;

namespace KS.Interfaces.DataAccess.Repositories
{
    public interface IStockRepository : IBaseRepository<Product>
    {
        Task<IList<StockIndexViewModel>> GetStock();
    }
}
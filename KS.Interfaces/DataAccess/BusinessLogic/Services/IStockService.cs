using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KS.Entities;
using KS.ViewModels.Stock;

namespace KS.Interfaces.DataAccess.BusinessLogic.Services
{
    public interface IStockService
    {
        Task UpdateStock(StockUpdateVm stockUpdateVm);
    }
}
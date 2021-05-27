using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KS.Entities;

namespace KS.Interfaces.DataAccess.BusinessLogic.Services
{
    public interface IStockService
    {
        IList<Stock> CheckListProduct(int warehouseID, int[] productsIds);
    }
}
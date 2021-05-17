using System.Threading.Tasks;
using KS.ViewModels.Admin.Order;

namespace KS.Interfaces.DataAccess.BusinessLogic.Services
{
    public interface IOrderService
    {
        Task<OrderListingViewModel> GetAllAsync();
        Task<int> GetDetailsAsync(int id);
    }
}
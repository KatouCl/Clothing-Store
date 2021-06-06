using System.Collections.Generic;
using System.Threading.Tasks;
using KS.Entities;
using KS.ViewModels.WishList;

namespace KS.Interfaces.DataAccess.BusinessLogic.Services
{
    public interface IWishListService
    {
        Task<WishList> AddToWishList(string customerId, int productId);
        IList<WishListVm> GetWishListDetails(string customerId);
    }
}
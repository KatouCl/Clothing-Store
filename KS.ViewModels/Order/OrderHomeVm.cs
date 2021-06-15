using System.Collections.Generic;
using KS.ViewModels.WishList;

namespace KS.ViewModels.Order
{
    public class OrderHomeVm
    {
        public List<LastOrdersVm> LastOrdersVms { get; set; }
        public List<WishListVm> WishListVms { get; set; }
    }
}
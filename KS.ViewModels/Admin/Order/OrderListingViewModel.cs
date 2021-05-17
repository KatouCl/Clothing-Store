using System.Collections.Generic;

namespace KS.ViewModels.Admin.Order
{
    public class OrderListingViewModel
    {
        public IEnumerable<OrderIndexViewModel> Orders { get; set; }
    }
}
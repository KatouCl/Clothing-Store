using System.Collections.Generic;

namespace KS.ViewModels.Session
{
    public class CartDetailsSessionVm
    {
        public List<CartDetailsItemSessionVm> Products { get; set; }

        public CartDetailsSessionVm()
        {
            Products = new List<CartDetailsItemSessionVm>();
        } 
    }
}
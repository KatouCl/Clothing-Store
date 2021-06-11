using System.Collections.Generic;

namespace KS.ViewModels.Cart
{
    public class CartDetailsVm
    {
        public CartDetailsVm()
        {
            Products = new List<CartItemVm>();
        }
        
        public IList<CartItemVm> Products { get; set; }
    }
}
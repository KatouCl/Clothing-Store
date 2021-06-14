using System.Collections.Generic;
using System.Linq;

namespace KS.ViewModels.Cart
{
    public class ProductCartVm
    {
        public List<CartItemVm> Products { get; set; }
        public decimal Price => Products.Sum(x => x.Price);
        public int Count => Products.Sum(x => x.Quantity);

        public ProductCartVm()
        {
            Products = new List<CartItemVm>();
        } 
    }
}
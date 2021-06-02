using System.Collections.Generic;
using System.Linq;
using KS.ViewModels.Product;

namespace KS.ViewModels.Cart
{
    public class ProductCartViewModel
    {
        public IEnumerable<ProductIndexViewModel> Products { get; set; }
        public decimal Price => Products.Sum(x => x.Price);
        // public int Count => Products.Sum(x => x.Count);
    }
}
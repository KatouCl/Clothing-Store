using System.Collections.Generic;
using System.Linq;

namespace KS.ViewModels.Cart
{
    public class ProductCartVm
    {
        public List<ProductCartVm> Products { get; set; }
        public decimal Price => Products.Sum(x => x.Price);
        public int Count => Products.Sum(x => x.Count);

        public ProductCartVm()
        {
            Products = new List<ProductCartVm>();
        } 
    }
}
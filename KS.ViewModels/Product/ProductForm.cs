using Microsoft.AspNetCore.Http;

namespace KS.ViewModels.Product
{
    public class ProductForm
    {
        public ProductIndexViewModel Product { get; set; } = new ProductIndexViewModel();

        public IFormFile ThumbnailImage { get; set; } 
    }
}
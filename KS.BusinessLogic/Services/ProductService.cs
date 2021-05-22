using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KS.Entities;
using KS.Interfaces.DataAccess.BusinessLogic.Services;
using KS.Interfaces.DataAccess.Repositories;
using KS.ViewModels.Product;

namespace KS.BusinessLogic.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }


        public async Task<ProductIndexViewModel> GetProductDetailsByIdAsync(int id)
        {
            var product = await _productRepository.GetByIdAsync(id);

            var productView = new ProductIndexViewModel
            {
                Id = product.Id,
                Name = product.Name,
                OldPrice = product.OldPrice,
                Price = product.Price,
                Description = product.Description,

                //TODO: Сделать вывод картинок
                //Images = product.Images.Select(x => x.Name).ToList(),
                //Structures = product.Structures.OrderBy(x => x.Id).Select(x => x.Name).ToList()
            };

            return productView;
        }
        public IEnumerable<ProductIndexViewModel> GetProductForCatalogAsync()
        {
            var products = _productRepository
                .GetAll()
                .OrderBy(x => x.Id)
                .Select(x => new ProductIndexViewModel
                {
                    Id = x.Id,
                    Name = x.Name,
                    OldPrice = x.OldPrice,
                    Price = x.Price,
                    Description = x.Description,
                    SpecialPrice = x.SpecialPrice,
                    ShortDescription = x.ShortDescription
                });

            return products;
        }
    }
}
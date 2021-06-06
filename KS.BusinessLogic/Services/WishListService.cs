using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KS.Entities;
using KS.Interfaces.DataAccess.BusinessLogic.Services;
using KS.Interfaces.DataAccess.Repositories;
using KS.ViewModels.WishList;

namespace KS.BusinessLogic.Services
{
    public class WishListService : IWishListService
    {
        private readonly IBaseRepository<Product> _productRepository;
        private readonly IBaseRepository<WishList> _wishListRepository;

        public WishListService(IBaseRepository<Product> productRepository,
            IBaseRepository<WishList> wishListRepository)
        {
            _productRepository = productRepository;
            _wishListRepository = wishListRepository;
        }

        public async Task<WishList> AddToWishList(string customerId, int productId)
        {
            var product = _productRepository.GetByIdAsync(productId).Result;
            var productInWishList = _wishListRepository.GetAllQuery().FirstOrDefault(x => x.ProductId == productId);

            if (productInWishList == null)
            {
                var model = new WishList
                {
                    CustomerId = customerId,
                    ProductId = product.Id,
                    Price = product.Price
                };
                await _wishListRepository.AddAsync(model);
            }

            await _wishListRepository.SaveChangesAsync();
            return productInWishList;
        }

        public IList<WishListVm> GetWishListDetails(string customerId)
        {
            var wishListProducts = _wishListRepository.GetAll()
                .Where(x => x.CustomerId == customerId)
                .Select(x => new WishListVm
                {
                    Id = x.Id,
                    CustomerId = x.CustomerId,
                    ProductId = x.ProductId,
                    Price = x.Price,
                    
                    ImageUrl = _productRepository.GetByIdAsync(x.ProductId).Result.CoverImageUrl,
                    ProductName = _productRepository.GetByIdAsync(x.ProductId).Result.Name
                }).ToList();
            
            return wishListProducts;
        }
    }
}
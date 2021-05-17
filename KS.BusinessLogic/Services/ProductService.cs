using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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

        // public Task<ProductDetailsViewModel> GetProductDetailsByIdAsync(int id)
        // {
        //     throw new System.NotImplementedException();
        // }
        //
        // public IEnumerable<ProductCartViewModel> GetProductForCatalogAsync()
        // {
        //     throw new System.NotImplementedException();
        // }
        //
        // public IEnumerable<ProductCartViewModel> GetProductForMainPage()
        // {
        //     throw new System.NotImplementedException();
        // }

        //public IEnumerable<ProductCartViewModel> GetProductForMainPage()
        //{
        //    var products = _productRepository
        //        .GetAll()
        //        .Where(x => x.OnMainPage)
        //        .OrderBy(x => x.Order)
        //        .Select(x => new ProductCartViewModel
        //        {
        //            Id = x.Id,
        //            Name = x.Name,
        //            OldPrice = x.OldPrice,
        //            Price = x.Price,
        //            IsNew = x.IsNew,
        //            Images = x.Images.OrderBy(x => x.Order).FirstOrDefault().Name,
        //        });

        //    return products;;
        //}

        //public IEnumerable<ProductCartViewModel> GetProductForCatalogAsync()
        //{
        //    var products = _productRepository
        //        .GetAll()
        //        .OrderBy(x => x.Id)
        //        .Select(x => new ProductCartViewModel
        //        {
        //            Id = x.Id,
        //            Name = x.Name,
        //            OldPrice = x.OldPrice,
        //            Price = x.Price,
        //            Brand = x.Brand,
        //            Category = x.Category,
        //            Color = x.Color,
        //            Description = x.Description,
        //            Group = x.Group,
        //            OnMainPage = x.OnMainPage,
        //            Seasons = x.Seasons,
        //            Size = x.Size,
        //            Guarantee = x.Guarantee,
        //            VendorCode = x.VendorCode,
        //            Quantity = x.Quantity,
        //            Discount = x.Discount,
        //        });

        //    return products;
        //}

        //public async Task<ProductDetailsViewModel> GetProductDetailsByIdAsync(int id)
        //{
        //    var product = await _productRepository.GetByIdAsync(id);

        //    var productView = new ProductDetailsViewModel
        //    {
        //        Id = product.Id,
        //        Name = product.Name,
        //        OldPrice = product.OldPrice,
        //        Price = product.Price,
        //        Discount = product.Discount,
        //        Quantity = product.Quantity,
        //        Description = product.Description,
        //        VendorCode = product.VendorCode,
        //        OnMainPage = product.OnMainPage,
        //        IsNew = product.IsNew,
        //        Guarantee = product.Guarantee,
        //        Size = product.Size,
        //        Brand = product.Brand,
        //        Color = product.Color,
        //        Category = product.Category,
        //        Group = product.Group,
        //        Seasons = product.Seasons

        //        //TODO: Сделать вывод картинок
        //        //Images = product.Images.Select(x => x.Name).ToList(),
        //        //Structures = product.Structures.OrderBy(x => x.Id).Select(x => x.Name).ToList()
        //    };

        //    return productView;
        //}
    }
}
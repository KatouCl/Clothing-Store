using System.Collections.Generic;
using System.Linq;
using KS.Entities;
using KS.Entities.Enums;
using KS.Interfaces.DataAccess.BusinessLogic.Services;
using KS.Interfaces.DataAccess.Repositories;
using KS.ViewModels.Category;

namespace KS.BusinessLogic.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly IBaseRepository<Product> _productRepository;

        public CategoryService(IBaseRepository<Product> productRepository)
        {
            _productRepository = productRepository;
        }
        
        public IEnumerable<CatalogViewModel> GetProductForCatalog()
        {
            var products = _productRepository.GetAll()
                .Select(x => new CatalogViewModel
                {
                    Id = x.Id,
                    Name = x.Name,
                    Slug = x.Slug,
                    ShortDescription = x.ShortDescription,
                    Description = x.Description,
                    Specification = x.Specification,
                    OldPrice = x.OldPrice,
                    Price = x.Price,
                    SpecialPrice = x.SpecialPrice,
                    SpecialPriceStart = x.SpecialPriceStart,
                    SpecialPriceEnd = x.SpecialPriceEnd,
                    IsFeatured = x.IsFeatured,
                    IsCallForPricing = x.IsCallForPricing,
                    IsAllowToOrder = x.IsAllowToOrder,
                    CategoryIds = x.Categories.Select(c => c.CategoryId).ToList(),
                    BrandId = x.BrandId,
                    TaxClassId = x.TaxClassId,
                    StockTrackingIsEnabled = x.StockTrackingIsEnabled,
                    GenderType = x.GenderType,
                    UnitType = x.UnitType
                });
            
            return products;
        }

        public IEnumerable<CategoryMaleViewModel> GetProductForMale()
        {
            var products = _productRepository.GetAll()
                .Where(x => x.GenderType == GenderType.Male)
                .Select(x => new CategoryMaleViewModel
                {
                    Id = x.Id,
                    Name = x.Name,
                    Slug = x.Slug,
                    ShortDescription = x.ShortDescription,
                    Description = x.Description,
                    Specification = x.Specification,
                    OldPrice = x.OldPrice,
                    Price = x.Price,
                    SpecialPrice = x.SpecialPrice,
                    SpecialPriceStart = x.SpecialPriceStart,
                    SpecialPriceEnd = x.SpecialPriceEnd,
                    IsFeatured = x.IsFeatured,
                    IsCallForPricing = x.IsCallForPricing,
                    IsAllowToOrder = x.IsAllowToOrder,
                    CategoryIds = x.Categories.Select(c => c.CategoryId).ToList(),
                    BrandId = x.BrandId,
                    TaxClassId = x.TaxClassId,
                    StockTrackingIsEnabled = x.StockTrackingIsEnabled,
                    GenderType = x.GenderType,
                    UnitType = x.UnitType
                });

            return products;
        }

        public IEnumerable<CategoryFemaleViewModel> GetProductForFemale()
        {
            var products = _productRepository.GetAll()
                .Where(x => x.GenderType == GenderType.Female)
                .Select(x => new CategoryFemaleViewModel
                {
                    Id = x.Id,
                    Name = x.Name,
                    Slug = x.Slug,
                    ShortDescription = x.ShortDescription,
                    Description = x.Description,
                    Specification = x.Specification,
                    OldPrice = x.OldPrice,
                    Price = x.Price,
                    SpecialPrice = x.SpecialPrice,
                    SpecialPriceStart = x.SpecialPriceStart,
                    SpecialPriceEnd = x.SpecialPriceEnd,
                    IsFeatured = x.IsFeatured,
                    IsCallForPricing = x.IsCallForPricing,
                    IsAllowToOrder = x.IsAllowToOrder,
                    CategoryIds = x.Categories.Select(c => c.CategoryId).ToList(),
                    BrandId = x.BrandId,
                    TaxClassId = x.TaxClassId,
                    StockTrackingIsEnabled = x.StockTrackingIsEnabled,
                    GenderType = x.GenderType,
                    UnitType = x.UnitType
                });

            return products;
        }
    }
}
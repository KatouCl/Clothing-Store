using System.Collections.Generic;
using System.Linq;
using KS.Entities;
using KS.Entities.Enums;
using KS.Interfaces.DataAccess.BusinessLogic.Services;
using KS.Interfaces.DataAccess.Repositories;
using KS.ViewModels.Category;
using KS.ViewModels.Warehouse;

namespace KS.BusinessLogic.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly IBaseRepository<Product> _productRepository;
        private readonly IBaseRepository<ProductCategory> _categoryRepository;
        private readonly IBaseRepository<Stock> _stockRepository;

        public CategoryService(IBaseRepository<Product> productRepository,
            IBaseRepository<ProductCategory> categoryRepository, IBaseRepository<Stock> stockRepository)
        {
            _productRepository = productRepository;
            _categoryRepository = categoryRepository;
            _stockRepository = stockRepository;
        }

        public IEnumerable<GoodsInStockVm> GetProductForCatalog(long? categoryId)
        {
            if (categoryId.HasValue)
            {
                //check 
                var checkCategory = _categoryRepository.GetAll()
                    .Where(x => x.CategoryId == categoryId)
                    .Select(x => new ProductCategory
                    {
                        Id = x.Id,
                        ProductId = x.ProductId,
                        Product = x.Product,
                        CategoryId = x.CategoryId,
                        Category = x.Category
                        });

                var products = _productRepository.GetAll()
                    .OrderBy(x => x.CreationDate)
                    .Join(
                        checkCategory,
                        product => product.Id,
                        category => category.Id,
                        (product, category) => new CatalogViewModel
                        {
                            Id = product.Id,
                            Name = product.Name,
                            Slug = product.Slug,
                            ShortDescription = product.ShortDescription,
                            Description = product.Description,
                            Specification = product.Specification,
                            OldPrice = product.OldPrice,
                            Price = product.Price,
                            SpecialPrice = product.SpecialPrice,
                            SpecialPriceStart = product.SpecialPriceStart,
                            SpecialPriceEnd = product.SpecialPriceEnd,
                            IsFeatured = product.IsFeatured,
                            IsCallForPricing = product.IsCallForPricing,
                            IsAllowToOrder = product.IsAllowToOrder,
                            CategoryIds = product.Categories.Select(x => x.CategoryId).ToList(),
                            BrandId = product.BrandId,
                            TaxClassId = product.TaxClassId,
                            StockTrackingIsEnabled = product.StockTrackingIsEnabled,
                            GenderType = product.GenderType,
                            UnitType = product.UnitType,
                            CategoryId = category.CategoryId,
                            CoverImageUrl = product.CoverImageUrl
                        }
                    );


                var query = products.Join(
                    _stockRepository.GetAllQuery(),
                    product => product.Id,
                    stock => stock.ProductId,
                    (product, stock) => new GoodsInStockVm
                    {
                        Id = product.Id,
                        Name = product.Name,
                        Slug = product.Slug,
                        ShortDescription = product.ShortDescription,
                        Description = product.Description,
                        Specification = product.Specification,
                        OldPrice = product.OldPrice,
                        Price = product.Price,
                        SpecialPrice = product.SpecialPrice,
                        SpecialPriceStart = product.SpecialPriceStart,
                        SpecialPriceEnd = product.SpecialPriceEnd,
                        IsFeatured = product.IsFeatured,
                        IsCallForPricing = product.IsCallForPricing,
                        IsAllowToOrder = product.IsAllowToOrder,
                        CategoryIds = product.CategoryIds,
                        BrandId = product.BrandId,
                        TaxClassId = product.TaxClassId,
                        StockTrackingIsEnabled = product.StockTrackingIsEnabled,
                        GenderType = product.GenderType,
                        UnitType = product.UnitType,
                        QuantityStock = stock.Quantity,
                        CoverImageUrl = product.CoverImageUrl
                    }
                );

                return query;
            }
            else
            {
                var products = _productRepository.GetAll()
                    .OrderBy(x => x.CreationDate)
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
                        CategoryIds = x.Categories.Select(x => x.CategoryId).ToList(),
                        BrandId = x.BrandId,
                        TaxClassId = x.TaxClassId,
                        StockTrackingIsEnabled = x.StockTrackingIsEnabled,
                        GenderType = x.GenderType,
                        UnitType = x.UnitType,
                        CoverImageUrl = x.CoverImageUrl
                    });

                var query = products.Join(
                    _stockRepository.GetAllQuery(),
                    product => product.Id,
                    stock => stock.ProductId,
                    (product, stock) => new GoodsInStockVm
                    {
                        Id = product.Id,
                        Name = product.Name,
                        Slug = product.Slug,
                        ShortDescription = product.ShortDescription,
                        Description = product.Description,
                        Specification = product.Specification,
                        OldPrice = product.OldPrice,
                        Price = product.Price,
                        SpecialPrice = product.SpecialPrice,
                        SpecialPriceStart = product.SpecialPriceStart,
                        SpecialPriceEnd = product.SpecialPriceEnd,
                        IsFeatured = product.IsFeatured,
                        IsCallForPricing = product.IsCallForPricing,
                        IsAllowToOrder = product.IsAllowToOrder,
                        CategoryIds = product.CategoryIds,
                        BrandId = product.BrandId,
                        TaxClassId = product.TaxClassId,
                        StockTrackingIsEnabled = product.StockTrackingIsEnabled,
                        GenderType = product.GenderType,
                        UnitType = product.UnitType,
                        QuantityStock = stock.Quantity,
                        CoverImageUrl = product.CoverImageUrl
                    }
                );

                return query;
            }
        }

        public IEnumerable<GoodsInStockVm> GetProductForMale(long? categoryId)
        {
            if (categoryId.HasValue)
            {
                //check 
                var checkCategory = _categoryRepository.GetAll().Where(x => x.CategoryId == categoryId)
                    .Select(x => new ProductCategory
                    {
                        Id = x.Id,
                        ProductId = x.ProductId,
                        Product = x.Product,
                        CategoryId = x.CategoryId,
                        Category = x.Category
                    });

                var products = _productRepository.GetAll()
                    .Where(x => x.GenderType == GenderType.Male)
                    .Join(
                        checkCategory,
                        product => product.Id,
                        category => category.Id,
                        (product, category) => new CategoryMaleViewModel
                        {
                            Id = product.Id,
                            Name = product.Name,
                            Slug = product.Slug,
                            ShortDescription = product.ShortDescription,
                            Description = product.Description,
                            Specification = product.Specification,
                            OldPrice = product.OldPrice,
                            Price = product.Price,
                            SpecialPrice = product.SpecialPrice,
                            SpecialPriceStart = product.SpecialPriceStart,
                            SpecialPriceEnd = product.SpecialPriceEnd,
                            IsFeatured = product.IsFeatured,
                            IsCallForPricing = product.IsCallForPricing,
                            IsAllowToOrder = product.IsAllowToOrder,
                            CategoryIds = product.Categories.Select(x => x.CategoryId).ToList(),
                            BrandId = product.BrandId,
                            TaxClassId = product.TaxClassId,
                            StockTrackingIsEnabled = product.StockTrackingIsEnabled,
                            GenderType = product.GenderType,
                            UnitType = product.UnitType,
                            CategoryId = category.CategoryId,
                            CoverImageUrl = product.CoverImageUrl
                        }
                    );


                var query = products.Join(
                    _stockRepository.GetAllQuery(),
                    product => product.Id,
                    stock => stock.ProductId,
                    (product, stock) => new GoodsInStockVm
                    {
                        Id = product.Id,
                        Name = product.Name,
                        Slug = product.Slug,
                        ShortDescription = product.ShortDescription,
                        Description = product.Description,
                        Specification = product.Specification,
                        OldPrice = product.OldPrice,
                        Price = product.Price,
                        SpecialPrice = product.SpecialPrice,
                        SpecialPriceStart = product.SpecialPriceStart,
                        SpecialPriceEnd = product.SpecialPriceEnd,
                        IsFeatured = product.IsFeatured,
                        IsCallForPricing = product.IsCallForPricing,
                        IsAllowToOrder = product.IsAllowToOrder,
                        CategoryIds = product.CategoryIds,
                        BrandId = product.BrandId,
                        TaxClassId = product.TaxClassId,
                        StockTrackingIsEnabled = product.StockTrackingIsEnabled,
                        GenderType = product.GenderType,
                        UnitType = product.UnitType,
                        QuantityStock = stock.Quantity,
                        CoverImageUrl = product.CoverImageUrl
                    }
                );

                return query;
            }
            else
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
                        UnitType = x.UnitType,
                        CoverImageUrl = x.CoverImageUrl
                    });

                var query = products.Join(
                    _stockRepository.GetAllQuery(),
                    product => product.Id,
                    stock => stock.ProductId,
                    (product, stock) => new GoodsInStockVm
                    {
                        Id = product.Id,
                        Name = product.Name,
                        Slug = product.Slug,
                        ShortDescription = product.ShortDescription,
                        Description = product.Description,
                        Specification = product.Specification,
                        OldPrice = product.OldPrice,
                        Price = product.Price,
                        SpecialPrice = product.SpecialPrice,
                        SpecialPriceStart = product.SpecialPriceStart,
                        SpecialPriceEnd = product.SpecialPriceEnd,
                        IsFeatured = product.IsFeatured,
                        IsCallForPricing = product.IsCallForPricing,
                        IsAllowToOrder = product.IsAllowToOrder,
                        CategoryIds = product.CategoryIds,
                        BrandId = product.BrandId,
                        TaxClassId = product.TaxClassId,
                        StockTrackingIsEnabled = product.StockTrackingIsEnabled,
                        GenderType = product.GenderType,
                        UnitType = product.UnitType,
                        QuantityStock = stock.Quantity,
                        CoverImageUrl = product.CoverImageUrl
                    }
                );

                return query;
            }
        }

        public IEnumerable<GoodsInStockVm> GetProductForFemale(long? categoryId)
        {
            if (categoryId.HasValue)
            {
                //check 
                var checkCategory = _categoryRepository.GetAll().Where(x => x.CategoryId == categoryId)
                    .Select(x => new ProductCategory
                    {
                        Id = x.Id,
                        ProductId = x.ProductId,
                        Product = x.Product,
                        CategoryId = x.CategoryId,
                        Category = x.Category
                    });

                var products = _productRepository.GetAll()
                    .Where(x => x.GenderType == GenderType.Female)
                    .Join(
                        checkCategory,
                        product => product.Id,
                        category => category.Id,
                        (product, category) => new CategoryFemaleViewModel
                        {
                            Id = product.Id,
                            Name = product.Name,
                            Slug = product.Slug,
                            ShortDescription = product.ShortDescription,
                            Description = product.Description,
                            Specification = product.Specification,
                            OldPrice = product.OldPrice,
                            Price = product.Price,
                            SpecialPrice = product.SpecialPrice,
                            SpecialPriceStart = product.SpecialPriceStart,
                            SpecialPriceEnd = product.SpecialPriceEnd,
                            IsFeatured = product.IsFeatured,
                            IsCallForPricing = product.IsCallForPricing,
                            IsAllowToOrder = product.IsAllowToOrder,
                            CategoryIds = product.Categories.Select(x => x.CategoryId).ToList(),
                            BrandId = product.BrandId,
                            TaxClassId = product.TaxClassId,
                            StockTrackingIsEnabled = product.StockTrackingIsEnabled,
                            GenderType = product.GenderType,
                            UnitType = product.UnitType,
                            CategoryId = category.CategoryId,
                            CoverImageUrl = product.CoverImageUrl
                        }
                    );

                var query = products.Join(
                    _stockRepository.GetAllQuery(),
                    product => product.Id,
                    stock => stock.ProductId,
                    (product, stock) => new GoodsInStockVm
                    {
                        Id = product.Id,
                        Name = product.Name,
                        Slug = product.Slug,
                        ShortDescription = product.ShortDescription,
                        Description = product.Description,
                        Specification = product.Specification,
                        OldPrice = product.OldPrice,
                        Price = product.Price,
                        SpecialPrice = product.SpecialPrice,
                        SpecialPriceStart = product.SpecialPriceStart,
                        SpecialPriceEnd = product.SpecialPriceEnd,
                        IsFeatured = product.IsFeatured,
                        IsCallForPricing = product.IsCallForPricing,
                        IsAllowToOrder = product.IsAllowToOrder,
                        CategoryIds = product.CategoryIds,
                        BrandId = product.BrandId,
                        TaxClassId = product.TaxClassId,
                        StockTrackingIsEnabled = product.StockTrackingIsEnabled,
                        GenderType = product.GenderType,
                        UnitType = product.UnitType,
                        QuantityStock = stock.Quantity,
                        CoverImageUrl = product.CoverImageUrl
                    }
                );

                return query;
            }
            else
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
                        UnitType = x.UnitType,
                        CoverImageUrl = x.CoverImageUrl
                    });

                var query = products.Join(
                    _stockRepository.GetAllQuery(),
                    product => product.Id,
                    stock => stock.ProductId,
                    (product, stock) => new GoodsInStockVm
                    {
                        Id = product.Id,
                        Name = product.Name,
                        Slug = product.Slug,
                        ShortDescription = product.ShortDescription,
                        Description = product.Description,
                        Specification = product.Specification,
                        OldPrice = product.OldPrice,
                        Price = product.Price,
                        SpecialPrice = product.SpecialPrice,
                        SpecialPriceStart = product.SpecialPriceStart,
                        SpecialPriceEnd = product.SpecialPriceEnd,
                        IsFeatured = product.IsFeatured,
                        IsCallForPricing = product.IsCallForPricing,
                        IsAllowToOrder = product.IsAllowToOrder,
                        CategoryIds = product.CategoryIds,
                        BrandId = product.BrandId,
                        TaxClassId = product.TaxClassId,
                        StockTrackingIsEnabled = product.StockTrackingIsEnabled,
                        GenderType = product.GenderType,
                        UnitType = product.UnitType,
                        QuantityStock = stock.Quantity,
                        CoverImageUrl = product.CoverImageUrl
                    }
                );

                return query;
            }
        }
    }
}
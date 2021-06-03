using System;
using System.Collections.Generic;
using KS.Entities.Enums;

namespace KS.Entities
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }
        public string Slug { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public string Specification { get; set; }
        public decimal Price { get; set; }
        public decimal? OldPrice { get; set; }
        public decimal? SpecialPrice { get; set; }
        public DateTimeOffset? SpecialPriceStart { get; set; }

        public DateTimeOffset? SpecialPriceEnd { get; set; }
        public bool HasOptions { get; set; }
        public bool IsFeatured { get; set; }

        public bool IsCallForPricing { get; set; }

        public bool IsAllowToOrder { get; set; }

        public bool StockTrackingIsEnabled { get; set; }

        public int StockQuantity { get; set; }
        
        
        public long? BrandId { get; set; }
        public Brand Brand { get; set; }
        
        public long? TaxClassId { get; set; }
        public TaxClass TaxClass { get; set; }
        
        public string CoverImageUrl { get; set; }
        
        public UnitType UnitType { get; set; }
        public GenderType GenderType { get; set; }
        
        public IList<ProductCategory> Categories { get; protected set; } = new List<ProductCategory>();
    
        public void AddCategory(ProductCategory category)
        {
            category.Product = this;
            Categories.Add(category);
        }
        public void UpdateCategory(ProductCategory category)
        {
            category.Product = this;
            Categories.Remove(category);
        }
    }
}

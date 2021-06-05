using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using KS.Entities.Enums;
using Microsoft.AspNetCore.Http;

namespace KS.ViewModels.Product
{
    public class ProductIndexViewModel
    {
        public ProductIndexViewModel()
        {
            // IsPublished = true;
            IsCallForPricing = false;
            IsAllowToOrder = true;
            Price = 0;
        }

        public long Id { get; set; }
        [Required(ErrorMessage = "Цена должна быть целочисленная")]
        [Range(1, 2000000)]
        public decimal Price { get; set; }

        [Range(1, 2000000)]
        public decimal? OldPrice { get; set; }

        public decimal? SpecialPrice { get; set; }

        public DateTimeOffset? SpecialPriceStart { get; set; }

        public DateTimeOffset? SpecialPriceEnd { get; set; }

        public bool IsCallForPricing { get; set; }

        public bool IsAllowToOrder { get; set; }
        
        [Required(ErrorMessage = "Введите название товара")]
        [StringLength(550, MinimumLength=3)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Введите название понятное для человека")]
        [StringLength(550, MinimumLength=3)]
        public string Slug { get; set; }


        [Required(ErrorMessage = "Введите короткое описание для товара")]
        [StringLength(8000, MinimumLength=3)]
        public string ShortDescription { get; set; }

        [Required(ErrorMessage = "Введите описание для товара")]
        [StringLength(8000, MinimumLength=3)]
        public string Description { get; set; }
        [Required(ErrorMessage = "Введите техническое описание для товара")]
        [StringLength(8000, MinimumLength=3)]
        public string Specification { get; set; }


        public bool IsFeatured { get; set; }

        public bool StockTrackingIsEnabled { get; set; }

        public IList<long> CategoryIds { get; set; } = new List<long>();

        [Display(Name = "Выберите изображение")]
        [Required]
        public IFormFile CoverImage { get; set; }
        public string CoverImageUrl { get; set; }

        public long? BrandId { get; set; }
        public long? TaxClassId { get; set; }
        public GenderType GenderType { get; set; }
        public UnitType UnitType { get; set; }
        public int QuantityStock { get; set; }

    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using KS.Entities.Enums;
using Microsoft.AspNetCore.Http;

namespace KS.ViewModels.Category
{
    public class CategoryFemaleViewModel
    {
        public long Id { get; set; }

        [Required(ErrorMessage = "Цена")]
        [Range(1, 2000000)]
        public decimal Price { get; set; }

        [Range(1, 2000000)] public decimal? OldPrice { get; set; }
        public decimal? SpecialPrice { get; set; }
        public DateTimeOffset? SpecialPriceStart { get; set; }
        public DateTimeOffset? SpecialPriceEnd { get; set; }
        public bool IsCallForPricing { get; set; }
        public bool IsAllowToOrder { get; set; }

        [Required(ErrorMessage = "Название товара")]
        [StringLength(550, MinimumLength = 3)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Slug")]
        [StringLength(550, MinimumLength = 3)]
        public string Slug { get; set; }

        [Required(ErrorMessage = "Короткое описание")]
        [StringLength(8000, MinimumLength = 3)]
        public string ShortDescription { get; set; }

        [Required(ErrorMessage = "Описание")]
        [StringLength(8000, MinimumLength = 3)]
        public string Description { get; set; }

        [Required(ErrorMessage = "Техническое описание")]
        [StringLength(8000, MinimumLength = 3)]
        public string Specification { get; set; }

        public bool IsFeatured { get; set; }
        public bool StockTrackingIsEnabled { get; set; }

        [Display(Name = "Изображение товара")]
        [Required]
        public IFormFile CoverImage { get; set; }

        public string CoverImageUrl { get; set; }

        public long? BrandId { get; set; }
        public long? TaxClassId { get; set; }
        public GenderType GenderType { get; set; }
        public UnitType UnitType { get; set; }
        public long CategoryId { get; set; }
        public IList<long> CategoryIds { get; set; } = new List<long>();
    }
}
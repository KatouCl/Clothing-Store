using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace KS.Entities
{
    public class Cart : BaseEntity
    {
        public Cart()
        {
            CreatedOn = DateTimeOffset.Now;
            LatestUpdatedOn = DateTimeOffset.Now;
            IsActive = true;
        }

        public long CustomerId { get; set; }

        public ApplicationUser Customer { get; set; }

        public long CreatedById { get; set; }

        public ApplicationUser CreatedBy { get; set; }

        public DateTimeOffset CreatedOn { get; set; }

        public DateTimeOffset LatestUpdatedOn { get; set; }

        public bool IsActive { get; set; }

        public bool LockedOnCheckout { get; set; }

        [StringLength(450)] public string CouponCode { get; set; }

        [StringLength(450)] public string CouponRuleName { get; set; }

        [StringLength(450)] public string ShippingMethod { get; set; }

        public bool IsProductPriceIncludeTax { get; set; }

        public decimal? ShippingAmount { get; set; }

        public decimal? TaxAmount { get; set; }

        public IList<CartItem> Items { get; set; } = new List<CartItem>();

        public string ShippingData { get; set; }

        [StringLength(1000)] public string OrderNote { get; set; }
    }
}
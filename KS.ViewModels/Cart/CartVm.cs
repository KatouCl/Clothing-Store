using System.Collections.Generic;

namespace KS.ViewModels.Cart
{
    public class CartVm
    {
        public long Id { get; set; }

        public bool LockedOnCheckout { get; set; }

        public string CouponCode { get; set; }

        public decimal SubTotal { get; set; }

        public string SubTotalString => SubTotal.ToString();

        public decimal Discount { get; set; }

        public string DiscountString => Discount.ToString();

        public string CouponValidationErrorMessage { get; set; }

        public bool IsProductPriceIncludeTax { get; set; }

        public decimal? TaxAmount { get; set; }

        public string OrderNote { get; set; }

        public string TaxAmountString => TaxAmount.HasValue ? TaxAmount.ToString() : "-";

        public decimal? ShippingAmount { get; set; }

        public string ShippingAmountString => ShippingAmount.HasValue ? ShippingAmount.ToString() : "-";

        public decimal SubTotalWithDiscount => SubTotal - Discount;

        public decimal SubTotalWithDiscountWithoutTax
        {
            get
            {
                if (IsProductPriceIncludeTax)
                {
                    return SubTotalWithDiscount - TaxAmount ?? 0;
                }

                return SubTotalWithDiscount;
            }
        }

        public decimal OrderTotal
        {
            get
            {
                if (IsProductPriceIncludeTax)
                {
                    return SubTotal + (ShippingAmount ?? 0) - Discount;
                }

                return SubTotal + (TaxAmount ?? 0) + (ShippingAmount ?? 0) - Discount;
            }
        }

        public string OrderTotalString => OrderTotal.ToString();

        public IList<CartItemVm> Items { get; set; } = new List<CartItemVm>();

        public bool IsValid
        {
            get
            {
                foreach (var item in Items)
                {
                    if (!item.IsProductAvailabeToOrder)
                    {
                        return false;
                    }

                    if (item.ProductStockTrackingIsEnabled && item.ProductStockQuantity < item.Quantity)
                    {
                        return false;
                    }
                }

                return true;
            }
        }
    }
}
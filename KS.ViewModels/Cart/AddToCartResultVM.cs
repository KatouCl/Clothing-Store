﻿namespace KS.ViewModels.Cart
{
    public class AddToCartResultVm
    {
        public string ProductName { get; set; }

        public string ProductImage { get; set; }

        public decimal ProductPrice { get; set; }

        public string VariationName { get; set; }

        public int Quantity { get; set; }

        public int CartItemCount { get; set; }

        public decimal CartAmount { get; set; }
    }
}
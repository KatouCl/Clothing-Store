﻿using System.Collections.Generic;

namespace KS.ViewModels.Cart
{
    public class CartItemVm
    {
        public long Id { get; set; }

        public long ProductId { get; set; }

        public string ProductName { get; set; }

        public string ProductImage { get; set; }

        public decimal ProductPrice { get; set; }

        public int ProductStockQuantity { get; set; }

        public bool ProductStockTrackingIsEnabled { get; set; }

        public bool IsProductAvailabeToOrder { get; set; }

        public int Quantity { get; set; }

        public decimal Total => Quantity * ProductPrice;
    }
}
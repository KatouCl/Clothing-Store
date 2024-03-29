﻿using System.Collections.Generic;
using KS.Entities;

namespace KS.ViewModels.Cart
{
    public class CartItemVm
    {
        public long Id { get; set; }

        public string CustomerId { get; set; }
        public ApplicationUser Customer { get; set; }

        public long ProductId { get; set; }
        public string ProductName { get; set; }
        // public Entities.Product Product { get; set; }
        public string ImageUrl { get; set; }
        public int Quantity { get; set; }
        public int QuantityStock { get; set; }
        public decimal Price { get; set; }
        public long StockId { get; set; }
        public decimal TotalPrice
        {
            get
            {
                return Quantity * Price;
            }
        }
    }
}

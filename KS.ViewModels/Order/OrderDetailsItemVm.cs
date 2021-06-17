using System;

namespace KS.ViewModels.Order
{
    public class OrderDetailsItemVm
    {
        public long Id { get; set; }
        public long ProductId { get; set; }
        public string ProductName { get; set; }
        public string CoverImageUrl { get; set; }
        public long OrderId { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal TotalPrice { get; set; }
        public DateTime CreationDate { get; set; }
    }
}
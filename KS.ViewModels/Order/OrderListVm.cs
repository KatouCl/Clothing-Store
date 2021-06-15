using System;

namespace KS.ViewModels.Order
{
    public class OrderListVm
    {
        public long Id { get; set; }
        public string Customer { get; set; }
        public decimal Price { get; set; }
        public int QuantityProduct { get; set; }
        public DateTime CreationDate { get; set; }
    }
}
using System;

namespace KS.ViewModels.Order
{
    public class LastOrdersVm
    {
        public long Id { get; set; }
        public long OrderId { get; set; }
        public string CustomerName { get; set; }
        public DateTime CreationDate { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
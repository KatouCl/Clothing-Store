using System;

namespace KS.ViewModels.Admin.Order
{
    public class OrderIndexViewModel
    {
        public int Id { get; set; }
        public DateTime CreationDate { get; set; }
        public string ClientName { get; set; }
        public decimal TotalPrice { get; set; }          
    }
}
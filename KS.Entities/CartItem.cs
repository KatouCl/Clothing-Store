using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace KS.Entities
{
    public class CartItem : BaseEntity
    {
        public string CartId { get; set; }
        public string CustomerId { get; set; }
        public virtual ApplicationUser Customer { get; set; }
        public long ProductId { get; set; }
        public virtual Product Product { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal TotalPrice
        {
            get { return Quantity * Price; }
        }
    }
}
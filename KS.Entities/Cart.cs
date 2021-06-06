using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace KS.Entities
{
    public class Cart : BaseEntity
    {
        public string CustomerId { get; set; }
        public ApplicationUser Customer { get; set; }

        public long ProductId { get; set; }
        public Product Product { get; set; }

        public int Quantity { get; set; }
        public decimal Price { get; set; }

        public decimal TotalPrice
        {
            get { return Quantity * Price; }
        }
    }
}
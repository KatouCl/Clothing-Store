using System;

namespace KS.Entities
{
    public class CartItem : BaseEntity
    {
        public DateTimeOffset CreatedOn { get; set; }

        public long ProductId { get; set; }

        public Product Product { get; set; }

        public int Quantity { get; set; }

        public long CartId { get; set; }

        public Cart Cart { get; set; }
    }
}
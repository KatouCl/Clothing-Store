using System.Collections.Generic;
using KS.Entities.Enums;

namespace KS.Entities
{
    public class Order : BaseEntity
    {
        public decimal Price { get; set; }
        public virtual IEnumerable<OrderItem> OrderItems { get; set; }
        public virtual Delivery Delivery { get; set; }
        public virtual ApplicationUser Customer { get; set; }
    }
}
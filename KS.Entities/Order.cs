using System.Collections.Generic;

namespace KS.Entities
{
    public class Order : BaseEntity
    {
        public decimal Price { get; set; }
        
        public virtual ApplicationUser Client { get; set; }
        public virtual IEnumerable<OrderItem> OrderItems { get; set; }
    }
}

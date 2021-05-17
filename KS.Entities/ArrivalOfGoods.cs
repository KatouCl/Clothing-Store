using System.Collections.Generic;

namespace KS.Entities
{
    public class ArrivalOfGoods : BaseEntity
    {
        public decimal TotalSum { get; set; }
        
        public virtual IEnumerable<Product> Products { get; set; }
    }
}
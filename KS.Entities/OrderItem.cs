namespace KS.Entities
{
    public class OrderItem : BaseEntity
    {
        public decimal Price { get; set; }
        public decimal TotalPrice { get; set; }
        public virtual Product Product { get; set; }
        public virtual Order Order { get; set; }
    }
}

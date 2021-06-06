namespace KS.Entities
{
    public class WishList : BaseEntity
    {
        
        public string CustomerId { get; set; }
        public ApplicationUser Customer { get; set; }

        public long ProductId { get; set; }
        public Product Product { get; set; }

        public decimal Price { get; set; }

    }
}
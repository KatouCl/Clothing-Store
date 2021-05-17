namespace KS.Entities
{
    public class ProductCategory : BaseEntity
    {

        public long CategoryId { get; set; }

        public long ProductId { get; set; }

        public Category Category { get; set; }

        public Product Product { get; set; }
    }
}
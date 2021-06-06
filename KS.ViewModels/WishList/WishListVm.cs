using KS.Entities;

namespace KS.ViewModels.WishList
{
    public class WishListVm
    {
        public long Id { get; set; }

        public string CustomerId { get; set; }
        public ApplicationUser Customer { get; set; }

        public long ProductId { get; set; }
        public string ProductName { get; set; }
        public Entities.Product Product { get; set; }
        public string ImageUrl { get; set; }
        public decimal Price { get; set; }
    }
}
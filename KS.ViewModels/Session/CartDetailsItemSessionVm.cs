namespace KS.ViewModels.Session
{
    public class CartDetailsItemSessionVm
    {
        public long Id { get; set; }

        public long ProductId { get; set; }
        public string ProductName { get; set; }
        // public Entities.Product Product { get; set; }
        public string ImageUrl { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal TotalPrice
        {
            get
            {
                return Quantity * Price;
            }
        } 
    }
}
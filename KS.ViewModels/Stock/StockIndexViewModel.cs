namespace KS.ViewModels.Stock
{
    public class StockIndexViewModel
    {
        public int Id { get; set; }
        public int ProductId { get; set; }

        public Entities.Product Product { get; set; }

        public int WarehouseId { get; set; }

        public Entities.Warehouse Warehouse { get; set; }

        public int Quantity { get; set; }

        public int ReservedQuantity { get; set; }
    }
}
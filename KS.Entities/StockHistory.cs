namespace KS.Entities
{
    public class StockHistory : BaseEntity
    {
        public int ProductId { get; set; }

        public Product Product { get; set; }

        public int WarehouseId { get; set; }

        public Warehouse Warehouse { get; set; }

        public int AdjustedQuantity { get; set; }

    }
}
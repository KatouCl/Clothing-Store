namespace KS.Entities
{
    public class StockHistory : BaseEntity
    {
        public long ProductId { get; set; }

        public Product Product { get; set; }

        public long WarehouseId { get; set; }

        public Warehouse Warehouse { get; set; }

        public int AdjustedQuantity { get; set; }

    }
}
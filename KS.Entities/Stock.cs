namespace KS.Entities
{
    public class Stock : BaseEntity
    {
        public long ProductId { get; set; }
        public Product Product { get; set; }
        public long WarehouseId { get; set; }
        public Warehouse Warehouse { get; set; }
        public int Quantity { get; set; }
    }
}
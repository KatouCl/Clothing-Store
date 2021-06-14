using System.Collections.Generic;

namespace KS.ViewModels.Warehouse
{
    public class MangeWarehouseProductItemViewModel
    {
        public long Id { get; set; }

        public string Name { get; set; }
        public long ProductId { get; set; }
        public int? Quantity { get; set; }
        public bool isChech { get; set; }
        public bool IsExistInWarehouse
        {
            get
            {
                if (Quantity > 0)
                {
                    return Quantity.HasValue;
                }

                return false;
            }
        }
    }
}
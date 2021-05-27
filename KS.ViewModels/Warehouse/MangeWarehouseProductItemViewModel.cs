using System.Collections.Generic;

namespace KS.ViewModels.Warehouse
{
    public class MangeWarehouseProductItemViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int? Quantity { get; set; }
        
        // public bool IsCheck { get; set; }
        public bool IsExistInWarehouse
        {
            get
            {
                return Quantity.HasValue;
            }
        }
    }
}
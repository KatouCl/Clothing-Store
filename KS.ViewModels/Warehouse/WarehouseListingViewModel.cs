using System.Collections.Generic;

namespace KS.ViewModels.Warehouse
{
    public class WarehouseListingViewModel
    {
        public IEnumerable<MangeWarehouseProductItemViewModel> MangeWarehouse { get; set; }
        public WarehouseIndexViewModel Warehouses { get; set; }
    }
}
using System.ComponentModel.DataAnnotations;

namespace KS.ViewModels.Warehouse
{
    public class WarehouseIndexViewModel
    {
        public int Id { get; set; }
        
        [Required(ErrorMessage = "Введите название")]
        [StringLength(450)]
        public string Name { get; set; }

        public string Vendor { get; set; }

        public string Address { get; set; }  
    }
}
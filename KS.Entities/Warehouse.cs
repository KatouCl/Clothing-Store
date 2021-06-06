using System.ComponentModel.DataAnnotations;

namespace KS.Entities
{
    public class Warehouse : BaseEntity
    {
        [Required(ErrorMessage = "Введите название")]
        [StringLength(450)]
        public string Name { get; set; }
        public string Vendor { get; set; }
        public string Address { get; set; } 
    }
}
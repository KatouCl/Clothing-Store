using System.ComponentModel.DataAnnotations;

namespace KS.Entities
{
    public class Warehouse : BaseEntity
    {
        public Warehouse() { }

        public Warehouse(int id)
        {
            Id = id;
        }

        [Required(ErrorMessage = "Введите название")]
        [StringLength(450)]
        public string Name { get; set; }

        public long AddressId { get; set; }

        public long? VendorId { get; set; }

        public string Vendor { get; set; }

        public string Address { get; set; } 
    }
}
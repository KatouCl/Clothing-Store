using System.ComponentModel.DataAnnotations;

namespace KS.ViewModels.Brand
{
    public class BrandIndexViewModel
    {
        public long Id { get; set; }
        [Required(ErrorMessage = "Введите название бренда")]
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
using System.ComponentModel.DataAnnotations;

namespace KS.ViewModels.Category
{
    public class CategoryIndexViewModel
    {
        public long Id { get; set; }
        [Required(ErrorMessage = "Введите название категории")]
        public string Name { get; set; }
        public string Slug { get; set; }
    }
}
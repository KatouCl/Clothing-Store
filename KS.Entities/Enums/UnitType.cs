using System.ComponentModel.DataAnnotations;

namespace KS.Entities.Enums
{
    public enum UnitType
    {
        [Display(Name = "Штука")]
        Thing = 1,
        [Display(Name = "Пара (2 шт.)")]
        Couple = 2,
        [Display(Name = "Упаковка")]
        Packaging = 3,
        [Display(Name = "Комплект")]
        Set = 4
    }
}
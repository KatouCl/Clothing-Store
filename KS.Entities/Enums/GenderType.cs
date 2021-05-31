using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace KS.Entities.Enums
{
    public enum GenderType : byte
    {
        [Display(Name = "Мужская одежда")]
        Male = 1,
        [Display(Name = "Женская одежда")]
        Female = 2,
        [Display(Name = "Трансгендор")]
        Transgender = 3
    }
}
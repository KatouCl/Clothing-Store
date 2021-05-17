using System.ComponentModel;

namespace KS.Entities.Enums
{
    public enum GenderType : byte
    {
        [Description("Мужская одежда")]
        Male = 1,
        [Description("Женская одежда")]
        Female = 2,
    }
}
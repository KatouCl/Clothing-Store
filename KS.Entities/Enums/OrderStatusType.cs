using System.ComponentModel;

namespace KS.Entities.Enums
{
    public enum OrderStatusType
    {
        [Description("В ожидании")]
        Pending = 1,
        [Description("Упаковано")]
        Packed = 2,
        [Description("Отправлено")]
        Shipped = 3
    }
}
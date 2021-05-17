using System.ComponentModel;

namespace KS.Entities.Enums
{
    public enum DeliveryType : byte
    {
        None = 0,
        [Description("Курьер")]
        Courier = 1,
        
        [Description("Транспортная компания CDEK")]
        TransportCompanyCDEK = 2,
        
        [Description("Почта России")]
        RussianPost = 3
    }
}

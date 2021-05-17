using System.ComponentModel;

namespace KS.Entities.Enums
{
    public enum SeasonType : byte
    {
        None = 0,
        [Description("Демисезон")]
        DemiSeason = 1,
        
        [Description("Осень-зима")]
        AutumnWinter = 2,
        
        [Description("Весна-лето")]
        SpringSummer = 3,
            
        [Description("Зима")]
        Winter = 4,
        
        [Description("Весна")]
        Spring = 5,
        
        [Description("Лето")]
        Summer = 6,
        
        [Description("Осень")]
        Autumn = 7,
            
        [Description("Мульти")]
        Multi = 8
    }
}
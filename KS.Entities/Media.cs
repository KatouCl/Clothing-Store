using System.ComponentModel.DataAnnotations;
using KS.Entities.Enums;

namespace KS.Entities
{
    public class Media : BaseEntity
    {
        [StringLength(450)]
        public string Caption { get; set; }

        public int FileSize { get; set; }

        [StringLength(450)]
        public string FileName { get; set; }

        public MediaType MediaType { get; set; } 
    }
}
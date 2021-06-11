using System.Collections.Generic;
using KS.Entities.Enums;

namespace KS.Entities
{
    public class Order : BaseEntity
    {
        public string OrderRef { get; set; }
        public string StripeReference { get; set; }

        public string FirstName { get; set; }
        public string LastName{ get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        public string Address { get; set; }
        public string City { get; set; }
        public string PostCode { get; set; }

        public OrderStatusType Status { get; set; }

        public ICollection<Stock> Stock { get; set; }
    }
}
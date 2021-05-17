namespace KS.Entities
{
    public class TaxClass : BaseEntity
    {
        public TaxClass(){}

        public TaxClass(int id)
        {
            Id = id;
        }
        public string Name { get; set; }
        public decimal Interest { get; set; }
    }
}
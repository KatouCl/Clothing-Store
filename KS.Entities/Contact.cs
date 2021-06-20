namespace KS.Entities
{
    public class Contact : BaseEntity
    {
        public string Title { get; set; }
        public string Place { get; set; }
        public string Number { get; set; }
        public string Context { get; set; }
    }
}
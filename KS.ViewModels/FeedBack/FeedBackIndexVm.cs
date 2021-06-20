using System;

namespace KS.ViewModels.FeedBack
{
    public class FeedBackIndexVm
    {
        public long Id { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string Comment { get; set; }
        public DateTime CreationDate { get; set; }
    }
}
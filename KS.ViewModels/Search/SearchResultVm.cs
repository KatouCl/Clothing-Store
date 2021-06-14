using System.Collections.Generic;
using KS.ViewModels.Category;

namespace KS.ViewModels.Search
{
    public class SearchResultVm
    {
        public  IEnumerable<GoodsInStockVm> Products { get; set; }
        public  string SearchQuery { get; set; }
        public  bool EmptySearchResults { get; set; } 
    }
}
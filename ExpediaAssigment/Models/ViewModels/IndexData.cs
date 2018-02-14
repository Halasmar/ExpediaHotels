using Hotels.Models.SystemModels;

namespace Hotels.Models.ViewModels
{
    public class IndexData
    {
        public Offers Offers { get; set; } = new Offers();

        public SearchFilters Filters { get; set; } = new SearchFilters();
    }
}

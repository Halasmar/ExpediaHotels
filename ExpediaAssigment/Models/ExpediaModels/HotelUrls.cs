using Newtonsoft.Json;

namespace Hotels.Models.ExpediaModels
{
    public class HotelUrls
    {
        [JsonProperty("hotelInfositeUrl")]
        public string InfositeUrl { get; set; }

        [JsonProperty("hotelSearchResultUrl")]
        public string SearchResultUrl { get; set; }
    }
}

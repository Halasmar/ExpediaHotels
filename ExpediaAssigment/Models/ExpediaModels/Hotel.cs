using Newtonsoft.Json;

namespace Hotels.Models.ExpediaModels
{
    public class Hotel
    {
        [JsonProperty("offerDateRange")]
        public OfferDate OfferDate { get; set; }

        [JsonProperty("destination")]
        public Destination Destination { get; set; }

        [JsonProperty("hotelInfo")]
        public HotelInfo HotelInfo { get; set; }

        [JsonProperty("hotelUrgencyInfo")]
        public HotelUrgencyInfo UrgencyInfo { get; set; }

        [JsonProperty("hotelPricingInfo")]
        public HotelPricingInfo PricingInfo { get; set; }

        [JsonProperty("hotelUrls")]
        public HotelUrls Urls { get; set; }
    }
}

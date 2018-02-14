using Newtonsoft.Json;

namespace Hotels.Models.ExpediaModels
{
    public class ExpediaOffers
    {
        [JsonProperty("offerInfo")]
        public OfferInfo OfferInfo { get; set; }

        [JsonProperty("userInfo")]
        public UserInfo UserInfo { get; set; }

        [JsonProperty("offers")]
        public Offers Offers { get; set; }
    }
}

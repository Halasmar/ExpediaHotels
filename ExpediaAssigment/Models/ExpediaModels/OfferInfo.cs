using Newtonsoft.Json;

namespace Hotels.Models.ExpediaModels
{
    public class OfferInfo
    {
        [JsonProperty("siteID")]
        public string SiteID { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("userSelectedCurrency")]
        public string UserSelectedCurrency { get; set; }
    }
}

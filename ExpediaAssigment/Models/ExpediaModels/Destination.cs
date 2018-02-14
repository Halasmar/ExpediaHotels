using Newtonsoft.Json;

namespace Hotels.Models.ExpediaModels
{
    public class Destination
    {
        [JsonProperty("regionID")]
        public string RegionID { get; set; }

        [JsonProperty("associatedMultiCityRegionId")]
        public string AssociatedMultiCityRegionId { get; set; }

        [JsonProperty("longName")]
        public string LongName { get; set; }

        [JsonProperty("shortName")]
        public string ShortName { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("province")]
        public string Province { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("tla")]
        public string Tla { get; set; }

        [JsonProperty("nonLocalizedCity")]
        public string NonLocalizedCity { get; set; }
    }
}

using Newtonsoft.Json;

namespace Hotels.Models.ExpediaModels
{
    public class OfferDate
    {
        [JsonProperty("travelStartDate")]
        public int[] TravelStartDate { get; set; }

        [JsonProperty("travelEndDate")]
        public int[] TravelEndDate { get; set; }

        [JsonProperty("lengthOfStay")]
        public int LengthOfStay { get; set; }
    }
}

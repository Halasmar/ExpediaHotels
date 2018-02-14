using Newtonsoft.Json;

namespace Hotels.Models.ExpediaModels
{
    public class HotelPricingInfo
    {
        [JsonProperty("averagePriceValue")]
        public double AveragePriceValue { get; set; }

        [JsonProperty("totalPriceValue")]
        public double TotalPriceValue { get; set; }

        [JsonProperty("crossOutPriceValue")]
        public double CrossOutPriceValue { get; set; }

        [JsonProperty("originalPricePerNight")]
        public double OriginalPricePerNight { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("percentSavings")]
        public double PercentSavings { get; set; }

        [JsonProperty("drr")]
        public bool Drr { get; set; }
    }
}

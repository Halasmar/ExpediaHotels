using Newtonsoft.Json;

namespace Hotels.Models.ExpediaModels
{
    public class Offers
    {
        [JsonProperty("Hotel")]
        public Hotel[] Hotels { get; set; }
    }
}

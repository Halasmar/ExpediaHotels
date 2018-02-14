using Newtonsoft.Json;

namespace Hotels.Models.ExpediaModels
{
    public class UserInfo
    {
        [JsonProperty("persona")]
        public Persona Persona { get; set; }

        [JsonProperty("userId")]
        public string UserId { get; set; }
    }
}

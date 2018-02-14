using Newtonsoft.Json;

namespace Hotels.Models.ExpediaModels
{
    public class Persona
    {
        [JsonProperty("personaType")]
        public string PersonaType { get; set; }
    }
}

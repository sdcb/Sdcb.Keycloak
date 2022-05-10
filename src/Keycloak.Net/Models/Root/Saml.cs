using Newtonsoft.Json;

namespace Sdcb.Keycloak.Models.Root
{
    public class Saml
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("protocol")]
        public Protocol Protocol { get; set; }

        [JsonProperty("protocolMapper")]
        public string ProtocolMapper { get; set; }

        [JsonProperty("consentRequired")]
        public bool? ConsentRequired { get; set; }

        [JsonProperty("config")]
        public SamlConfig Config { get; set; }
    }
}
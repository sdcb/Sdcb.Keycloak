using Newtonsoft.Json;

namespace Sdcb.Keycloak.Models.Root
{
    public class LoginProtocol
    {
        [JsonProperty("internal")]
        public bool? Internal { get; set; }

        [JsonProperty("providers")]
        public LoginProtocolProviders Providers { get; set; }
    }
}
using Newtonsoft.Json;

namespace Sdcb.Keycloak.Models.Root
{
    public class ClientAuthenticator
    {
        [JsonProperty("internal")]
        public bool? Internal { get; set; }

        [JsonProperty("providers")]
        public ClientAuthenticatorProviders Providers { get; set; }
    }
}
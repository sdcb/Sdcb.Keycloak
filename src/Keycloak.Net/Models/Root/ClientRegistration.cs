using Newtonsoft.Json;

namespace Sdcb.Keycloak.Models.Root
{
    public class ClientRegistration
    {
        [JsonProperty("internal")]
        public bool? Internal { get; set; }

        [JsonProperty("providers")]
        public ClientRegistrationProviders Providers { get; set; }
    }
}
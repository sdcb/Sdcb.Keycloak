using Newtonsoft.Json;

namespace Sdcb.Keycloak.Models.Root
{
    public class ClientRegistrationPolicy
    {
        [JsonProperty("internal")]
        public bool? Internal { get; set; }

        [JsonProperty("providers")]
        public ClientRegistrationPolicyProviders Providers { get; set; }
    }
}
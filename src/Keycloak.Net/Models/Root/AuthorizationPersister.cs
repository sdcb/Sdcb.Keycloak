using Newtonsoft.Json;

namespace Sdcb.Keycloak.Models.Root
{
    public class AuthorizationPersister
    {
        [JsonProperty("internal")]
        public bool? Internal { get; set; }

        [JsonProperty("providers")]
        public AuthorizationPersisterProviders Providers { get; set; }
    }
}
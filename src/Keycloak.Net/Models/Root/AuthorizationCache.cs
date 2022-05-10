using Newtonsoft.Json;

namespace Sdcb.Keycloak.Models.Root
{
    public class AuthorizationCache
    {
        [JsonProperty("internal")]
        public bool? Internal { get; set; }

        [JsonProperty("providers")]
        public HasDefault Providers { get; set; }
    }
}
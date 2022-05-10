using Newtonsoft.Json;

namespace Sdcb.Keycloak.Models.IdentityProviders
{
    public class IdentityProviderInfo
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("id")]
        public string Id { get; set; }
    }
}

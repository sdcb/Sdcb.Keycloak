using Newtonsoft.Json;

namespace Sdcb.Keycloak.Models.AuthorizationScopes
{
    public class AuthorizationScope
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}

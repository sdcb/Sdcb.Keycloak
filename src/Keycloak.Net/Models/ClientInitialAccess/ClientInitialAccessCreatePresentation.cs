using Newtonsoft.Json;

namespace Sdcb.Keycloak.Models.ClientInitialAccess
{
    public class ClientInitialAccessCreatePresentation
    {
        [JsonProperty("count")]
        public int? Count { get; set; }
        [JsonProperty("expiration")]
        public int? Expiration { get; set; }
    }
}

using Newtonsoft.Json;

namespace Sdcb.Keycloak.Models.Root
{
    public class ConnectionsJpaProviders
    {
        [JsonProperty("default")]
        public Default Default { get; set; }
    }
}
using Newtonsoft.Json;

namespace Sdcb.Keycloak.Models.Root
{
    public class ConnectionsJpaUpdaterProviders
    {
        [JsonProperty("liquibase")]
        public HasOrder Liquibase { get; set; }
    }
}
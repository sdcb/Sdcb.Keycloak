using Newtonsoft.Json;

namespace Sdcb.Keycloak.Models.Root
{
    public class KeycloakStorageUserStorageProviderMetadata
    {
        [JsonProperty("synchronizable")]
        public bool? Synchronizable { get; set; }
    }
}
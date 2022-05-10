using Newtonsoft.Json;

namespace Sdcb.Keycloak.Models.Root
{
    public class AuthorizationPersisterProviders
    {
        [JsonProperty("jpa")]
        public HasOrder Jpa { get; set; }
    }
}
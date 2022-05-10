using Newtonsoft.Json;

namespace Sdcb.Keycloak.Models.Root
{
    public class AuthorizationProviders
    {
        [JsonProperty("authorization")]
        public HasOrder Authorization { get; set; }
    }
}
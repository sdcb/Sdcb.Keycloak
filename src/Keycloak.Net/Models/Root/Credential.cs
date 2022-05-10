using Newtonsoft.Json;

namespace Sdcb.Keycloak.Models.Root
{
    public class Credential
    {
        [JsonProperty("internal")]
        public bool? Internal { get; set; }

        [JsonProperty("providers")]
        public CredentialProviders Providers { get; set; }
    }
}
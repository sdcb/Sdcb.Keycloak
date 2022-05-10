using Newtonsoft.Json;

namespace Sdcb.Keycloak.Models.Root
{
    public class FormAuthenticator
    {
        [JsonProperty("internal")]
        public bool? Internal { get; set; }

        [JsonProperty("providers")]
        public FormAuthenticatorProviders Providers { get; set; }
    }
}
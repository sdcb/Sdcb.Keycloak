using Newtonsoft.Json;

namespace Sdcb.Keycloak.Models.Root
{
    public class RequiredAction
    {
        [JsonProperty("internal")]
        public bool? Internal { get; set; }

        [JsonProperty("providers")]
        public RequiredActionProviders Providers { get; set; }
    }
}
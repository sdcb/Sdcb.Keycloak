using Newtonsoft.Json;

namespace Sdcb.Keycloak.Models.Root
{
    public class Hash
    {
        [JsonProperty("internal")]
        public bool? Internal { get; set; }

        [JsonProperty("providers")]
        public HashProviders Providers { get; set; }
    }
}
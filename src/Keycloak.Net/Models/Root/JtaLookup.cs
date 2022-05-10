using Newtonsoft.Json;

namespace Sdcb.Keycloak.Models.Root
{
    public class JtaLookup
    {
        [JsonProperty("internal")]
        public bool? Internal { get; set; }

        [JsonProperty("providers")]
        public JtaLookupProviders Providers { get; set; }
    }
}
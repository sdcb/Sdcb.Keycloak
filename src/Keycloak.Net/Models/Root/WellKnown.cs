using Newtonsoft.Json;

namespace Sdcb.Keycloak.Models.Root
{
    public class WellKnown
    {
        [JsonProperty("internal")]
        public bool? Internal { get; set; }

        [JsonProperty("providers")]
        public WellKnownProviders Providers { get; set; }
    }
}
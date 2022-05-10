using Newtonsoft.Json;

namespace Sdcb.Keycloak.Models.Root
{
    public class BruteForceProtector
    {
        [JsonProperty("internal")]
        public bool? Internal { get; set; }

        [JsonProperty("providers")]
        public BruteForceProtectorProviders Providers { get; set; }
    }
}
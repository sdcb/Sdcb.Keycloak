using Newtonsoft.Json;

namespace Sdcb.Keycloak.Models.Root
{
    public class BruteForceProtectorProviders
    {
        [JsonProperty("default-brute-force-detector")]
        public HasOrder DefaultBruteForceDetector { get; set; }
    }
}
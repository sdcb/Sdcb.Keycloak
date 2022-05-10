using Newtonsoft.Json;

namespace Sdcb.Keycloak.Models.Root
{
    public class TruststoreProviders
    {
        [JsonProperty("file")]
        public HasOrder File { get; set; }
    }
}
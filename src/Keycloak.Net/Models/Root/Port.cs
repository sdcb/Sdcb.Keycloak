using Newtonsoft.Json;

namespace Sdcb.Keycloak.Models.Root
{
    public class Port
    {
        [JsonProperty("internal")]
        public bool? Internal { get; set; }

        [JsonProperty("providers")]
        public ExportProviders Providers { get; set; }
    }
}
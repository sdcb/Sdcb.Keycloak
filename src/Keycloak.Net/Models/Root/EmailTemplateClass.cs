using Newtonsoft.Json;

namespace Sdcb.Keycloak.Models.Root
{
    public class EmailTemplateClass
    {
        [JsonProperty("internal")]
        public bool? Internal { get; set; }

        [JsonProperty("providers")]
        public AccountProviders Providers { get; set; }
    }
}
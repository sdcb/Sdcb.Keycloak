using Newtonsoft.Json;

namespace Sdcb.Keycloak.Models.Root
{
    public class FormAction
    {
        [JsonProperty("internal")]
        public bool? Internal { get; set; }

        [JsonProperty("providers")]
        public FormActionProviders Providers { get; set; }
    }
}
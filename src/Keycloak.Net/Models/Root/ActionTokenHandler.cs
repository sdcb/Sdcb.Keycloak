using Newtonsoft.Json;

namespace Sdcb.Keycloak.Models.Root
{
    public class ActionTokenHandler
    {
        [JsonProperty("internal")]
        public bool? Internal { get; set; }

        [JsonProperty("providers")]
        public ActionTokenHandlerProviders Providers { get; set; }
    }
}
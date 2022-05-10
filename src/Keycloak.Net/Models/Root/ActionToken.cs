using Newtonsoft.Json;

namespace Sdcb.Keycloak.Models.Root
{
    public class ActionToken
    {
        [JsonProperty("internal")]
        public bool? Internal { get; set; }

        [JsonProperty("providers")]
        public ActionTokenProviders Providers { get; set; }
    }
}
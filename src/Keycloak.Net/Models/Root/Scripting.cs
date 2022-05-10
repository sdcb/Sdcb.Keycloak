using Newtonsoft.Json;

namespace Sdcb.Keycloak.Models.Root
{
    public class Scripting
    {
        [JsonProperty("internal")]
        public bool? Internal { get; set; }

        [JsonProperty("providers")]
        public ScriptingProviders Providers { get; set; }
    }
}
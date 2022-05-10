using Newtonsoft.Json;

namespace Sdcb.Keycloak.Models.Root
{
    public class ScriptingProviders
    {
        [JsonProperty("script-based-auth")]
        public HasOrder ScriptBasedAuth { get; set; }
    }
}
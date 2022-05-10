using Newtonsoft.Json;

namespace Sdcb.Keycloak.Models.Root
{
    public class HasDefault
    {
        [JsonProperty("default")]
        public HasOrder Default { get; set; }
    }
}
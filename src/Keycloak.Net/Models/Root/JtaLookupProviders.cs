using Newtonsoft.Json;

namespace Sdcb.Keycloak.Models.Root
{
    public class JtaLookupProviders
    {
        [JsonProperty("jboss")]
        public HasOrder Jboss { get; set; }
    }
}
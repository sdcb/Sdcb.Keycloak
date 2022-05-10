using Newtonsoft.Json;

namespace Sdcb.Keycloak.Models.Root
{
    public class HostnameProviders
    {
        [JsonProperty("request")]
        public HasOrder Request { get; set; }
    }
}
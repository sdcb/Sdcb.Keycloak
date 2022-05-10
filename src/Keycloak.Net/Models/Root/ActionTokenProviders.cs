using Newtonsoft.Json;

namespace Sdcb.Keycloak.Models.Root
{
    public class ActionTokenProviders
    {
        [JsonProperty("infinispan")]
        public HasOrder Infinispan { get; set; }
    }
}
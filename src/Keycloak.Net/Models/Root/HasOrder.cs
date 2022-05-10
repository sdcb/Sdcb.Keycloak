using Newtonsoft.Json;

namespace Sdcb.Keycloak.Models.Root
{
    public class HasOrder
    {
        [JsonProperty("order")]
        public long Order { get; set; }
    }
}
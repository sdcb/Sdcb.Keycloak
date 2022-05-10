using Newtonsoft.Json;

namespace Sdcb.Keycloak.Models.Root
{
    public class Default
    {
        [JsonProperty("order")]
        public long Order { get; set; }

        [JsonProperty("operationalInfo")]
        public OperationalInfo OperationalInfo { get; set; }
    }
}
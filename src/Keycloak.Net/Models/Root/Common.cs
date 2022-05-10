using Newtonsoft.Json;

namespace Sdcb.Keycloak.Models.Root
{
    public class Common
    {
        [JsonProperty("name")]
        public Name Name { get; set; }
    }
}
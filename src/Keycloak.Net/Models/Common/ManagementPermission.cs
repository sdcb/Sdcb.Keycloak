using Newtonsoft.Json;

namespace Sdcb.Keycloak.Models.Common
{
    public class ManagementPermission
    {
        [JsonProperty("enabled")]
        public bool? Enabled { get; set; }
    }
}

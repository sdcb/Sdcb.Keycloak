using Newtonsoft.Json;

namespace Sdcb.Keycloak.Models.RealmsAdmin
{
    public class AuthDetails
    {
        [JsonProperty("clientId")]
        public string ClientId { get; set; }
        [JsonProperty("ipAddress")]
        public string IpAddress { get; set; }
        [JsonProperty("realmId")]
        public string RealmId { get; set; }
        [JsonProperty("userId")]
        public string UserId { get; set; }
    }
}

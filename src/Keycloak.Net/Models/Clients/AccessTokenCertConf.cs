using Newtonsoft.Json;

namespace Sdcb.Keycloak.Models.Clients
{
    public class AccessTokenCertConf
    {
        [JsonProperty("x5t#S256")]
        public string X5Ts256 { get; set; }
    }
}

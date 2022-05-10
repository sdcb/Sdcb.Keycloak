using Newtonsoft.Json;

namespace Sdcb.Keycloak.Models.Root
{
    public class LoginProtocolProviders
    {
        [JsonProperty("saml")]
        public HasOrder Saml { get; set; }

        [JsonProperty("openid-connect")]
        public HasOrder OpenIdConnect { get; set; }
    }
}
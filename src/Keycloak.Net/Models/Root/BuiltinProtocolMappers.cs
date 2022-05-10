using System.Collections.Generic;
using Newtonsoft.Json;

namespace Sdcb.Keycloak.Models.Root
{
    public class BuiltinProtocolMappers
    {
        [JsonProperty("saml")]
        public List<Saml> Saml { get; set; }

        [JsonProperty("openid-connect")]
        public List<OpenIdConnect> OpenIdConnect { get; set; }
    }
}
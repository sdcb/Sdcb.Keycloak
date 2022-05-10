using Sdcb.Keycloak.Common.Converters;
using Newtonsoft.Json;

namespace Sdcb.Keycloak.Models.Root
{
    [JsonConverter(typeof(ProtocolConverter))]
    public enum Protocol
    {
        DockerV2, 
        OpenIdConnect, 
        Saml
    }
}
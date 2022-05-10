using Newtonsoft.Json;

namespace Sdcb.Keycloak.Models.Root
{
    public class CredentialProviders
    {
        [JsonProperty("keycloak-otp")]
        public HasOrder KeycloakOtp { get; set; }

        [JsonProperty("keycloak-password")]
        public HasOrder KeycloakPassword { get; set; }
    }
}
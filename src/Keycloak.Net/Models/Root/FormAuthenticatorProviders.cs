using Newtonsoft.Json;

namespace Sdcb.Keycloak.Models.Root
{
    public class FormAuthenticatorProviders
    {
        [JsonProperty("registration-page-form")]
        public HasOrder RegistrationPageForm { get; set; }
    }
}
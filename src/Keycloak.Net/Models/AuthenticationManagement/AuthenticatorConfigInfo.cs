using System.Collections.Generic;
using Sdcb.Keycloak.Models.Common;
using Newtonsoft.Json;

namespace Sdcb.Keycloak.Models.AuthenticationManagement
{
    public class AuthenticatorConfigInfo
    {
        [JsonProperty("helpText")]
        public string HelpText { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("properties")]
        public IEnumerable<ConfigProperty> Properties { get; set; }
        [JsonProperty("providerId")]
        public string ProviderId { get; set; }
    }
}

using Newtonsoft.Json;

namespace Sdcb.Keycloak.Models.Root
{
    public class AccountProviders
    {
        [JsonProperty("freemarker")]
        public HasOrder Freemarker { get; set; }
    }
}
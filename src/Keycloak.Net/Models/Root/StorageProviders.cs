using Newtonsoft.Json;

namespace Sdcb.Keycloak.Models.Root
{
    public class StorageProviders
    {
        [JsonProperty("ldap")]
        public HasOrder Ldap { get; set; }

        [JsonProperty("kerberos")]
        public HasOrder Kerberos { get; set; }
    }
}
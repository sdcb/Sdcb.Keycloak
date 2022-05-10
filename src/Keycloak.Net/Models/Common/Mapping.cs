using System.Collections.Generic;
using Sdcb.Keycloak.Models.Roles;
using Newtonsoft.Json;

namespace Sdcb.Keycloak.Models.Common
{
    public class Mapping
    {
        [JsonProperty("clientMappings")]
        public IDictionary<string, ClientRoleMapping> ClientMappings { get; set; }
        [JsonProperty("realmMappings")]
        public IEnumerable<Role> RealmMappings { get; set; }
    }
}

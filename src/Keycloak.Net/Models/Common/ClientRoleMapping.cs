using Sdcb.Keycloak.Models.Roles;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Sdcb.Keycloak.Models.Common
{
    public class ClientRoleMapping
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("client")]
        public string Client { get; set; }
        [JsonProperty("mappings")]
        public List<Role> Mappings { get; set; }
    }
}

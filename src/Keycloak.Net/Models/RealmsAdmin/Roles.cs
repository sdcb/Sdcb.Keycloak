using System.Collections.Generic;
using Sdcb.Keycloak.Models.Roles;
using Newtonsoft.Json;

namespace Sdcb.Keycloak.Models.RealmsAdmin
{
    public class Roles
    {
        [JsonProperty("client")]
        public IDictionary<string, object> Client { get; set; }
        [JsonProperty("realm")]
        public IEnumerable<Role> Realm { get; set; }
    }
}

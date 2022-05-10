using System.Collections.Generic;
using Sdcb.Keycloak.Common.Converters;
using Sdcb.Keycloak.Models.Clients;
using Sdcb.Keycloak.Models.Groups;
using Sdcb.Keycloak.Models.Users;
using Newtonsoft.Json;

namespace Sdcb.Keycloak.Models.RealmsAdmin
{
    public class PartialImport
    {
        public IEnumerable<Client> Clients { get; set; }
        public IEnumerable<Group> Groups { get; set; }
        public IEnumerable<IdentityProvider> IdentityProviders { get; set; }
        public string IfResourceExists { get; set; }
        [JsonConverter(typeof(PoliciesConverter))]
        public Policies Policy { get; set; }
        public Roles Roles { get; set; }
        public IEnumerable<User> Users { get; set; }
    }
}

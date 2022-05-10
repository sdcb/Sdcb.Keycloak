using System.Collections.Generic;
using Newtonsoft.Json;

namespace Sdcb.Keycloak.Models.Clients
{
    public class Resource
    {
        [JsonProperty("rsid")]
        public string RsId { get; set; }

        [JsonProperty("rsname")]
        public string RsName { get; set; }

        [JsonProperty("scopes")]
        public IEnumerable<string> Scopes { get; set; }
    }
}

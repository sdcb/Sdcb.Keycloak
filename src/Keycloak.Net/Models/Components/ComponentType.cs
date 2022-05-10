using System.Collections.Generic;
using Sdcb.Keycloak.Models.Common;
using Newtonsoft.Json;

namespace Sdcb.Keycloak.Models.Components
{
    public class ComponentType
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("helpText")]
        public string HelpText { get; set; }
        [JsonProperty("properties")]
        public IEnumerable<ConfigProperty> Properties { get; set; }
        [JsonProperty("metadata")]
        public IDictionary<string, object> Metadata { get; set; }
    }
}

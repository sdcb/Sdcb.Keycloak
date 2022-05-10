using System.Collections.Generic;
using Newtonsoft.Json;

namespace Sdcb.Keycloak.Models.Key
{
    public class KeysMetadata
    {
        [JsonProperty("active")]
        public Active Active { get; set; }
        [JsonProperty("keys")]
        public IEnumerable<Key> Keys { get; set; }
    }
}

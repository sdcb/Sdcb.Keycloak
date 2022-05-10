using System.Collections.Generic;
using Newtonsoft.Json;

namespace Sdcb.Keycloak.Models.Root
{
    public class Authenticator
    {
        [JsonProperty("internal")]
        public bool? Internal { get; set; }

        [JsonProperty("providers")]
        public Dictionary<string, HasOrder> Providers { get; set; }
    }
}
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Sdcb.Keycloak.Models.Root
{
    public class ProfileInfo
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("disabledFeatures")]
        public List<string> DisabledFeatures { get; set; }

        [JsonProperty("previewFeatures")]
        public List<string> PreviewFeatures { get; set; }

        [JsonProperty("experimentalFeatures")]
        public List<string> ExperimentalFeatures { get; set; }
    }
}
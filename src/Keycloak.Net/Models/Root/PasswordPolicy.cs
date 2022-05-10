using Newtonsoft.Json;

namespace Sdcb.Keycloak.Models.Root
{
    public class PasswordPolicy
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("configType")]
        public ConfigType? ConfigType { get; set; }

        [JsonProperty("defaultValue")]
        public string DefaultValue { get; set; }

        [JsonProperty("multipleSupported")]
        public bool? MultipleSupported { get; set; }
    }
}
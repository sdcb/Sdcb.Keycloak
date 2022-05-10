using Sdcb.Keycloak.Common.Converters;
using Newtonsoft.Json;

namespace Sdcb.Keycloak.Models.Root
{
    [JsonConverter(typeof(ConfigTypeConverter))]
    public enum ConfigType
    {
        Int, 
        String
    }
}
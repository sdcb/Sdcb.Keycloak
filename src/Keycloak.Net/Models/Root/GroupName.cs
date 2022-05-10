using Sdcb.Keycloak.Common.Converters;
using Newtonsoft.Json;

namespace Sdcb.Keycloak.Models.Root
{
    [JsonConverter(typeof(GroupNameConverter))]
    public enum GroupName
    {
        Social, 
        UserDefined
    }
}
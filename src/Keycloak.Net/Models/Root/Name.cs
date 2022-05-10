using Sdcb.Keycloak.Common.Converters;
using Newtonsoft.Json;

namespace Sdcb.Keycloak.Models.Root
{
    [JsonConverter(typeof(NameConverter))]
    public enum Name
    {
        Base, 
        Keycloak, 
        RhSso
    }
}
using Sdcb.Keycloak.Common.Converters;
using Newtonsoft.Json;

namespace Sdcb.Keycloak.Models.Root
{
    [JsonConverter(typeof(CategoryConverter))]
    public enum Category
    {
        AttributeStatementMapper, 
        DockerAuthMapper, 
        GroupMapper, 
        RoleMapper, 
        TokenMapper
    }
}
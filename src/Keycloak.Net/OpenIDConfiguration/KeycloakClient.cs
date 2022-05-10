using System.Threading.Tasks;
using Flurl.Http;
using Sdcb.Keycloak.Models.OpenIDConfiguration;

namespace Sdcb.Keycloak
{
    public partial class KeycloakClient
    {
        public async Task<OpenIDConfiguration> GetOpenIDConfigurationAsync(string realm) => await GetBaseUrl(realm)
            .AppendPathSegment($"/realms/{realm}/.well-known/openid-configuration")
            .GetJsonAsync<OpenIDConfiguration>()
            .ConfigureAwait(false);
    }
}

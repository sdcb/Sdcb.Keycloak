using System.Threading.Tasks;
using Flurl.Http;
using Sdcb.Keycloak.Models.Key;

namespace Sdcb.Keycloak
{
    public partial class KeycloakClient
    {
        public async Task<KeysMetadata> GetKeysAsync(string realm) => await GetBaseUrl(realm)
            .AppendPathSegment($"/admin/realms/{realm}/keys")
            .GetJsonAsync<KeysMetadata>()
            .ConfigureAwait(false);
    }
}

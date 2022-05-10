using System.Collections.Generic;
using Newtonsoft.Json;

namespace Sdcb.Keycloak.Models.Common
{
    public class GlobalRequestResult
    {
        [JsonProperty("failedRequests")]
        public IEnumerable<string> FailedRequests { get; set; }
        [JsonProperty("successRequests")]
        public IEnumerable<string> SuccessRequests { get; set; }
    }
}

using Newtonsoft.Json;

namespace Sdcb.Keycloak.Models.Root
{
    public class TimerProviders
    {
        [JsonProperty("basic")]
        public HasOrder Basic { get; set; }
    }
}
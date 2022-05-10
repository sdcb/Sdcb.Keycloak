using Newtonsoft.Json;

namespace Sdcb.Keycloak.Models.Root
{
    public class Timer
    {
        [JsonProperty("internal")]
        public bool? Internal { get; set; }

        [JsonProperty("providers")]
        public TimerProviders Providers { get; set; }
    }
}
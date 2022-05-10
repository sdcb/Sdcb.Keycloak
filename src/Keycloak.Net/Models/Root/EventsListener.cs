using Newtonsoft.Json;

namespace Sdcb.Keycloak.Models.Root
{
    public class EventsListener
    {
        [JsonProperty("internal")]
        public bool? Internal { get; set; }

        [JsonProperty("providers")]
        public EventsListenerProviders Providers { get; set; }
    }
}
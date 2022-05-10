using Newtonsoft.Json;

namespace Sdcb.Keycloak.Models.Root
{
    public class EventsListenerProviders
    {
        [JsonProperty("jboss-logging")]
        public HasOrder JbossLogging { get; set; }

        [JsonProperty("email")]
        public HasOrder Email { get; set; }
    }
}
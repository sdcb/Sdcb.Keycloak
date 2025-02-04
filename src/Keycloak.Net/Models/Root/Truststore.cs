﻿using Newtonsoft.Json;

namespace Sdcb.Keycloak.Models.Root
{
    public class Truststore
    {
        [JsonProperty("internal")]
        public bool? Internal { get; set; }

        [JsonProperty("providers")]
        public TruststoreProviders Providers { get; set; }
    }
}
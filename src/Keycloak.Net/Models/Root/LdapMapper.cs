﻿using Newtonsoft.Json;

namespace Sdcb.Keycloak.Models.Root
{
    public class LdapMapper
    {
        [JsonProperty("internal")]
        public bool? Internal { get; set; }

        [JsonProperty("providers")]
        public LdapMapperProviders Providers { get; set; }
    }
}
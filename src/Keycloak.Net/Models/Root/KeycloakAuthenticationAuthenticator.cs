﻿using System.Collections.Generic;
using Sdcb.Keycloak.Models.Common;
using Newtonsoft.Json;

namespace Sdcb.Keycloak.Models.Root
{
    public class KeycloakAuthenticationAuthenticator
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("helpText")]
        public string HelpText { get; set; }

        [JsonProperty("properties")]
        public List<ConfigProperty> Properties { get; set; }

        [JsonProperty("metadata")]
        public MetadataClass Metadata { get; set; }
    }
}
﻿using Newtonsoft.Json;

namespace Sdcb.Keycloak.Models.Root
{
    public class Provider
    {
        [JsonProperty("groupName")]
        public GroupName GroupName { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }
}
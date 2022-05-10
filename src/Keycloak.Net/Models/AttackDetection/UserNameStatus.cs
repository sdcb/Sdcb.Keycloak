﻿using Newtonsoft.Json;

namespace Sdcb.Keycloak.Models.AttackDetection
{
    public class UserNameStatus
    {
        [JsonProperty("numFailures")]
        public int? NumFailures { get; set; }
        [JsonProperty("disabled")]
        public bool? Disabled { get; set; }
        [JsonProperty("lastIPFailure")]
        public string LastIpFailure { get; set; }
        [JsonProperty("lastFailure")]
        public int? LastFailure { get; set; }
    }
}

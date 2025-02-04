﻿using System.Collections.Generic;
using Newtonsoft.Json;

namespace Sdcb.Keycloak.Models.Clients
{
    public class AccessTokenAccess
    {
        [JsonProperty("roles")] 
        public IEnumerable<string> Roles  { get; set; }
        [JsonProperty("verify_caller")] 
        public bool? VerifyCaller { get; set; }
    }
}

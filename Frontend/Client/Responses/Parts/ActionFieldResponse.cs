﻿using Newtonsoft.Json;
using System.Collections.Generic;

namespace Frontend.Client.Responses.Parts
{
    public class ActionFieldResponse
    {
        [JsonProperty]
        public List<FieldResponse> Fields { get; set; } = new List<FieldResponse>();
    }
}

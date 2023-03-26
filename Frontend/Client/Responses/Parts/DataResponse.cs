﻿using Newtonsoft.Json;

namespace Frontend.Client.Responses.Parts
{
    internal class DataResponse
    {
        [JsonProperty]
        public string Value { get; set; }

        [JsonProperty]
        public string FieldName { get; set; }
    }
}
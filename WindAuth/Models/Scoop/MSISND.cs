﻿// Generated by Xamasoft JSON Class Generator
// http://www.xamasoft.com/json-class-generator

using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace WindDataLib
{

    public class MSISND
    {

        [JsonProperty("LineType")]
        public string LineType { get; set; }

        [JsonProperty("IsDefault")]
        public bool IsDefault { get; set; }

        [JsonProperty("Msisdn")]
        public long Msisdn { get; set; }

        [JsonProperty("IsRegistered")]
        public bool IsRegistered { get; set; }
    }

}
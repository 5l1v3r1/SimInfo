﻿// Generated by Xamasoft JSON Class Generator
// http://www.xamasoft.com/json-class-generator

using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace WindDataLib.Scoop
{

    public class WalletData
    {

        [JsonProperty("Common")]
        public Common Common { get; set; }

        [JsonProperty("Wallets")]
        public Wallet[] Wallets { get; set; }
    }

}
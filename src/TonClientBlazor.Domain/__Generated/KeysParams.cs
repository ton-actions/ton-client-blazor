﻿using System.Text.Json.Serialization;

namespace ch1seL.TonClientBlazor.__Generated
{
    public class KeysParams
    {
        [JsonPropertyName("account")] public string Account { get; set; }

        [JsonPropertyName("accountKeys")] public TonPublicSecretPair AccountKeys { get; set; }

        [JsonPropertyName("signedManagementAccessKey")]
        public string SignedManagementAccessKey { get; set; }

        [JsonPropertyName("keys")] public Key[] Keys { get; set; }
    }
}
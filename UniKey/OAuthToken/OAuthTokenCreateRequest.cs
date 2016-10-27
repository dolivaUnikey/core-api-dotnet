// Copyright 2012-2016 Unikey Technologies, Inc. All Rights Reserved.
// 
using Newtonsoft.Json;

namespace Unikey.OAuthToken
{
    public class OAuthTokenCreateRequest : BaseRequest
    {
        [JsonProperty("grant_type")]
        public string GrantType { get; set; }

        [JsonProperty("client_id")]
        public string ClientId { get; set; }

        [JsonProperty("client_secret")]
        public string ClientSecret { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }
}

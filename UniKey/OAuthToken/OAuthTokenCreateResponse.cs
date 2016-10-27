// Copyright 2012-2016 Unikey Technologies, Inc. All Rights Reserved.
// 
using Newtonsoft.Json;

namespace Unikey.OAuthToken
{
    public class OAuthTokenCreateResponse : BaseRequest
    {
        [JsonProperty("access_token")]
        public string AccessToken { get; set; }

        [JsonProperty("expires_in")]
        public float ExpiresIn { get; set; }

        [JsonProperty("refresh_token")]
        public string RefreshToken { get; set; }

        [JsonProperty("token_type")]
        public string TokenType { get; set; }
    }
}

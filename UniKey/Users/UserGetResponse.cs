// Copyright 2012-2016 Unikey Technologies, Inc. All Rights Reserved.
// 
using Newtonsoft.Json;

namespace Unikey.Users
{
    public class UserGetResponse : BaseRequest
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}

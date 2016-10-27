// Copyright 2012-2016 Unikey Technologies, Inc. All Rights Reserved.
// 
using Newtonsoft.Json;

namespace Unikey.Locks
{
    public class LockGetResponse : BaseResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}

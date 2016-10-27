// Copyright 2012-2016 Unikey Technologies, Inc. All Rights Reserved.
// 
using Newtonsoft.Json;

namespace Unikey.Locks
{
    public class LockCommandCreateResponse : BaseResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("lock_id")]
        public string LockId { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }
    }
}
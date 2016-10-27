// Copyright 2012-2016 Unikey Technologies, Inc. All Rights Reserved.
// 
using Newtonsoft.Json;

namespace Unikey.Locks
{
    public class LockCommandCreateRequest : BaseRequest
    {
        [JsonProperty("lock_id")]
        public string LockId { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }
}

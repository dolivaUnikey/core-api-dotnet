// Copyright 2012-2016 Unikey Technologies, Inc. All Rights Reserved.
// 
using System.Collections.Generic;
using Newtonsoft.Json;
using Unikey.Locks;

namespace Unikey.Users
{
    public class UserLocksGetResponse
    {
        [JsonProperty("locks")]
        public List<LockGetResponse> Locks;
    }
}

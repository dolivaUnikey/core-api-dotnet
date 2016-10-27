using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace UnikeyAPI.Locks
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

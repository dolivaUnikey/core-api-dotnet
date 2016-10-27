using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace UnikeyAPI.Locks
{
    public class LockCommandCreateRequest : BaseRequest
    {
        [JsonProperty("lock_id")]
        public string LockId { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }
}

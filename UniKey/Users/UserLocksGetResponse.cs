using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using UnikeyAPI.Locks;

namespace UnikeyAPI.Users
{
    public class UserLocksGetResponse
    {
        [JsonProperty("locks")]
        public List<LockGetResponse> Locks;
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace GCM_Sender
{
    public class Response
    {
        public string multicast_id { get; set; }
        public int success { get; set; }
        public int failure { get; set; }
        public int canonical_ids { get; set; }
        public Result[] results { get; set; }

        public static implicit operator string(Response r)
        {
            return (string)JsonConvert.SerializeObject(r);
        }
        public static implicit operator Response(string r)
        {
            return JsonConvert.DeserializeObject<Response>(r);
        }
    }
}

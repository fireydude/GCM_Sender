using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace GCM_Sender
{
    public class Request
    { 
        public string[] registration_ids { get; set; }
        public object data { get; set; }

        public static implicit operator string(Request r)
        {
            if (r.registration_ids.Length == 0)
                throw new Exception("At least one registration_ids is required");

            return (string)JsonConvert.SerializeObject(r);
        }
        public static implicit operator Request(string r)
        {
            return JsonConvert.DeserializeObject<Request>(r);
        }
    }
}

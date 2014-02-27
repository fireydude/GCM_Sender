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
            return (string)JsonConvert.SerializeObject(r);
        }
        public static implicit operator Request(string r)
        {
            return JsonConvert.DeserializeObject<Request>(r);
        }
    }
}

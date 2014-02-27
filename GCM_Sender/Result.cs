using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCM_Sender
{
    public class Result
    {
        public string message_id { get; set; }
        public string registration_id { get; set; }
        public string error { get; set; }
    }
}

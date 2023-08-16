using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace IPv4_to_int32
{
    public class IPConvert
    {
        public static uint ToInt32(string ip)
        {
            return (uint)IPAddress.NetworkToHostOrder((int)IPAddress.Parse(ip).Address);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.NetworkInformation;

namespace PingRequest
{
    class Request 
    {

        private string adr;
        private Ping ping;

        public Request(string adr,Ping ping)
        {
            this.adr = adr;
            this.ping = ping;
        }

      
        public void reguestPing()
        {
    
            PingReply pr = this.ping.Send(this.adr);
            if (pr.Status == IPStatus.Success)
            {
                Console.WriteLine(pr.Address + " " + pr.Status + " " + pr.Options.Ttl);
            }
            else
            {
                Console.WriteLine(pr.Status + " ");
            }

        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.NetworkInformation;
using System.Threading;

namespace PingRequest
{
    class Program
    {
        static void Main(string[] args)
        {
            using (Ping pn = new Ping())
            {
                Request r = new Request("www.facebook.com", pn);


                

                for (int i = 0; i < 5; i++)
                {
                    r.reguestPing();
                    Thread.Sleep(5000);
                }
            }
            Console.WriteLine("Kraj");
            Console.ReadLine();
            
        }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace OutputIP
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string myComputer = Dns.GetHostName();

            Console.WriteLine("컴퓨터 이름: " + myComputer);

            IPHostEntry entry = Dns.GetHostEntry(myComputer);

            foreach (IPAddress ipAddress in entry.AddressList)
            {
                Console.WriteLine(ipAddress.AddressFamily + ": " + ipAddress);
            }

            IPHostEntry entry0 = Dns.GetHostEntry("www.ilati.com");

            foreach (IPAddress ipAddress in entry0.AddressList)
            {
                Console.WriteLine(ipAddress.AddressFamily + ": " + ipAddress);
            }
        }
    }
}
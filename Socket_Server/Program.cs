using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Net.Sockets;
using System.Threading;
using System.Net;

namespace Socket_Server
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Thread serverThread = new Thread(serverFunc);
            serverThread.IsBackground = true;
            serverThread.Start();

            Console.WriteLine("종료");
            Console.ReadLine();
        }

        private static void serverFunc(Object obj)
        {
            using (Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp))
            {
                IPAddress ipAddress = GetCurrentIPAddress();

                if (null == ipAddress)
                {
                    Console.WriteLine("No NIC");
                    return;
                }
                //ipAddress = IPAddress.Parse("0.0.0.0");
                IPEndPoint endPoint = new IPEndPoint(IPAddress.Any, 10200);

                socket.Bind(endPoint);

                byte[] recvBytes = new byte[1024];
                EndPoint clientEP = new IPEndPoint(IPAddress.None, 0);

                while (true)
                {
                    int nRecv = socket.ReceiveFrom(recvBytes, ref clientEP);

                    string txt = Encoding.UTF8.GetString(recvBytes, 0, nRecv);
                    byte[] sendBytes = Encoding.UTF8.GetBytes("HELLO: " + txt);

                    socket.SendTo(sendBytes, clientEP);
                }
            }
        }

        private static IPAddress GetCurrentIPAddress()
        {
            IPAddress[] addrs = Dns.GetHostEntry(Dns.GetHostName()).AddressList;

            foreach (IPAddress ipAddr in addrs)
            {
                if (ipAddr.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ipAddr;
                }
            }
            return null;
        }
    }
}
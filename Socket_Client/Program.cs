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
            for (int i = 0; i < 3; ++i)
            {
                Thread clientThread = new Thread(clientFunc);
                clientThread.IsBackground = true;
                clientThread.Start();
            }

            Console.WriteLine("종료");
            Console.ReadLine();
        }

        private static void clientFunc(Object obj)
        {
            using (Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp))
            {
                IPAddress ipAddress = GetCurrentIPAddress();

                EndPoint serverEP = new IPEndPoint(GetCurrentIPAddress(), 10200);

                int nTimes = 5;

                while (nTimes-- > 0)
                {
                    byte[] buf = Encoding.UTF8.GetBytes(DateTime.Now.ToString());
                    socket.SendTo(buf, serverEP);

                    byte[] recvBytes = new byte[1024];
                    int nRecv = socket.ReceiveFrom(recvBytes, ref serverEP);
                    string txt = Encoding.UTF8.GetString(recvBytes, 0, nRecv);

                    Console.WriteLine(txt);
                    Thread.Sleep(1000);
                }

                socket.Close();
                Console.WriteLine("UDP Client Closed");
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
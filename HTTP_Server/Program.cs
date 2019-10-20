using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace HTTP_Server
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            using (Socket srvSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp))
            {
                Console.WriteLine("https://localhost:8000 으로 방문");

                IPEndPoint endPoint = new IPEndPoint(IPAddress.Any, 8000);

                srvSocket.Bind(endPoint);
                srvSocket.Listen(10);

                while (true)
                {
                    Socket clntSocket = srvSocket.Accept();
                    ThreadPool.QueueUserWorkItem(httpProcessFunc, clntSocket);
                }
            }
        }

        private static void httpProcessFunc(object state)
        {
            Socket socket = state as Socket;

            byte[] reqBuf = new byte[4096];
            socket.Receive(reqBuf);

            string header = "HTTP/1.0 200 OK\nContent-Type: text/html; charset=UTF-8\r\n\r\n";

            string body = "<html><body><mark>테스트 HTML</mark> 웹페이지.</body></html>";

            byte[] resqBuf = Encoding.UTF8.GetBytes(header + body);

            socket.Send(resqBuf);

            socket.Close();
        }
    }
}
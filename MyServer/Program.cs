using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace MyServer
{
    class Program
    {
        static void Main(string[] args)
        {
            const string ip = "127.0.0.1";
            const int port = 8080;
            IPEndPoint tcpEndPoint = new IPEndPoint(IPAddress.Parse(ip), port);
            Socket tcpSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            tcpSocket.Bind(tcpEndPoint);
            tcpSocket.Listen(5);
            StringBuilder data = new StringBuilder();
            while (true)
            {
                Socket listener = tcpSocket.Accept();    
                var bufer = new byte[256];
                var size = 0;

                do
                {
                    size = listener.Receive(bufer);
                    data.Append(Encoding.UTF8.GetString(bufer, 0, size));
                }
                while (listener.Available > 0);

                Console.WriteLine(data);

                listener.Send(Encoding.UTF8.GetBytes("Uspeh"));
                listener.Shutdown(SocketShutdown.Both);
                listener.Close();

            }
        }
    }
}

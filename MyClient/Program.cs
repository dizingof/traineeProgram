using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace MyClient
{
    class Program
    {
        static void Main(string[] args)
        {
            const string ip = "127.0.0.1";
            const int port = 8080;
            IPEndPoint tcpEndPoint = new IPEndPoint(IPAddress.Parse(ip), port);
            Socket tcpSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            Console.WriteLine("Vvedite soobshenie");
            var message = Console.ReadLine();
            var data = Encoding.UTF8.GetBytes(message);
            tcpSocket.Connect(tcpEndPoint);
            tcpSocket.Send(data);
            var bufer = new byte[256];
            var size = 0;
            var answer = new StringBuilder();

            do
            {
                size = tcpSocket.Receive(bufer);
                answer.Append(Encoding.UTF8.GetString(bufer, 0, size));
            }
            while (tcpSocket.Available > 0);
            Console.WriteLine(answer.ToString());
            tcpSocket.Shutdown(SocketShutdown.Both);
            tcpSocket.Close();
            Console.ReadLine();
        }
    }
}

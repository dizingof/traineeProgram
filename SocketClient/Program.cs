using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace SocketClient
{
    class Program
    {
        static void Main(string[] args)
        {
            const string ip = "127.0.0.1";
            const int port = 45000;

            while (true)
            {
                Socket mySocket = new Socket(SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint endPoint = new IPEndPoint(IPAddress.Parse(ip), port);
            mySocket.Connect(endPoint);
            
                Console.WriteLine("Vvedite soobshenie");
                var message = Console.ReadLine();
                var data = Encoding.UTF8.GetBytes(message);
                mySocket.Send(data);
                mySocket.Shutdown(SocketShutdown.Both);
                mySocket.Close();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace SocketServer
{
    class Program
    {
        static void Main(string[] args)
        {
            const string ip = "127.0.0.1";
            const int port = 45000;
            const int counterConnections = 10;

            Socket mySocket = new Socket(SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint endPoint = new IPEndPoint(IPAddress.Parse(ip), port);
            mySocket.Bind(endPoint);
            mySocket.Listen(counterConnections);
            //StringBuilder data = new StringBuilder();
            while (true)
            {
                Socket inputSocket = mySocket.Accept();
                byte[] myBuffer = new byte[256];
                int receivedMess = inputSocket.Receive(myBuffer);
                //data.Append(Encoding.UTF8.GetString(myBuffer, 0, receivedMess));
                StringBuilder data = new StringBuilder(Encoding.UTF8.GetString(myBuffer, 0, receivedMess));
                Console.WriteLine(data);
                inputSocket.Send(Encoding.UTF8.GetBytes("Uspeh"));
                inputSocket.Shutdown(SocketShutdown.Both);
                inputSocket.Close();
                
            }
            
        }

        public void test()
        {
            int a = 0;
            int b = 10;
            do
            {
                if (a % 2 == 0)
                {
                    Console.WriteLine(a);
                }                
                a++;
            }
            while (a < b);

            Console.ReadLine();
        }
    }
}

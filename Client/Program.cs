using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
			try
			{
				TcpClient client = new TcpClient("127.0.0.1", 7000);
				Console.WriteLine("Client connected");
				NetworkStream stream = client.GetStream();
				byte[] bytes = new byte[256];
				stream.Read(bytes, 0, bytes.Length);
				string answer = Encoding.ASCII.GetString(bytes);
				Console.WriteLine(answer);
				client.Close();
				Console.WriteLine("Client closed");
			}
			catch (Exception ex)
			{

				Console.WriteLine(ex.Message);
			}
			Console.ReadLine();
        }
    }
}

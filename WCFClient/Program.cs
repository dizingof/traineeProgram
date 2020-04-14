using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace WCFClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Client";
            Uri address = new Uri("http://localhost:45500/IContract");
            BasicHttpBinding binding = new BasicHttpBinding();
            EndpointAddress endpoint = new EndpointAddress(address);
            ChannelFactory<IContract> factory = new ChannelFactory<IContract>(binding, endpoint);
            IContract channel = factory.CreateChannel();
            channel.Say("Hello wcf!!!");
            Console.ReadLine();
        }
    }
}

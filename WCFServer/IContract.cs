using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace WCFServer
{
    [ServiceContract]
    interface IContract
    {
        [OperationContract]
        string Say(string input);
    }
}

using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.ServiceModel;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

// Create a ServiceHost and NetNamedPipeBinding in the “Program.cs” file to provide connection for the client(s).
// Ensure to add a Console.ReadLine to pause the program during operation.

namespace ServerApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string address = "net.pipe://localhost/AstroServer";
            ServiceHost serviceHost = new ServiceHost(typeof(AstroServer));
            NetNamedPipeBinding binding = new NetNamedPipeBinding(NetNamedPipeSecurityMode.None);
            serviceHost.AddServiceEndpoint(typeof(IAstroContract), binding, address);
            serviceHost.Open();
            Console.WriteLine("ServiceHost is running. Press <<Return>> to Exit");
            Console.ReadLine();
            serviceHost.Close();
        }
    }
}

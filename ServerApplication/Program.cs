using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

// Create a ServiceHost and NetNamedPipeBinding in the “Program.cs” file to provide connection for the client(s).
// Ensure to add a Console.ReadLine to pause the program during operation.

namespace ServerApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(typeof(AstroServer), new Uri[] { new Uri("net.pipe://localhost") }))
            {
                host.AddServiceEndpoint(typeof(IAstroContract), new NetNamedPipeBinding(), "PipeReverse");
                host.Open();
                Console.WriteLine("Service is available. " + "Press <ENTER> to exit. ");
                Console.ReadLine(); 
                host.Close();
            }
        }
    }
}

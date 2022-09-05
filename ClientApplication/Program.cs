using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientApplication
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new DataProcessing());

            //ChannelFactory<IAstroContract> pipeFactory = new ChannelFactory<IAstroContract>(new NetNamedPipeBinding(), new EndpointAddress("net.pipe://localhost/PipeReverse"));
            //IAstroContract pipeProxy = pipeFactory.CreateChannel();
            //while (true)
            //{
            //    string str = Console.ReadLine(); 
                
            //}
        }
    }
}

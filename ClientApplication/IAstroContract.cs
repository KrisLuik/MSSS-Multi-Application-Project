using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace ClientApplication
{
    [ServiceContract]
    internal interface IAstroContract
    {
        [OperationContract]
        double StarVelocity(double observedWavelength, double restWavelength);
        double StarDistance(double arcsecondsAngle);
        double TempInKelvin(double Celcius);
        double EventHorizon(double Blackholemass);
    }
}

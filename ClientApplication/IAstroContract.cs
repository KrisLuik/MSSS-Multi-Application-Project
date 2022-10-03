using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace ClientApplication
{
    [ServiceContract]
    public interface IAstroContract
    {
        [OperationContract]
        double StarVelocity(double observedWavelength, double restWavelength);
        [OperationContract]
        double StarDistance(double arcsecondsAngle);
        [OperationContract]
        double TempInKelvin(double Celcius);
        [OperationContract]
        double EventHorizon(double Blackholemass);
    }
}

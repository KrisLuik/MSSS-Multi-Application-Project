using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

// Create the ServiceContract file called “IAstroContract.cs” which will require an Interface that references the AstroMath.DLL
// and four OperationContract (one for each calculation). 

namespace ServerApplication
{
    [ServiceContract]
    // The ServiceContract attribute tells WCF that this interface can be exposed for client use.
    public interface IAstroContract
    {
        [OperationContract]
        // The OperationContract attribute tells WCF that ReverseString is part of this service and can 
        // be used by clients.
        double StarVelocity(double observedWavelength, double restWavelength);
        double StarDistance(double arcsecondsAngle);
        double TempInKelvin(double Celcius);
        double EventHorizon(double Blackholemass);
    }
}

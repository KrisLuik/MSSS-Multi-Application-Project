using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using AstroMath;

// Create the server file called “AstroServer.cs” which implements the IAstroContract.
// Add a new instance of the class library method and then create four methods with the suitable input parameters and return types.

namespace ServerApplication
{
    // Implementation of the interface on the server side.
    // Instance context mode parameter specifies the life time of service object.
    // InstanceContextMode.Single sets one instance of service for all calls.
    // [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class AstroServer : IAstroContract
    {
        // FourMethods getMethods = new FourMethods();
        public double StarVelocity(double observedWavelength, double restWavelength)
        {
            return AstroMath.FourMethods.StarVelocity(observedWavelength, restWavelength);
        }
        public double StarDistance(double arcsecondsAngle)
        {
            return AstroMath.FourMethods.StarDistance(arcsecondsAngle);
        }
        public double TempInKelvin(double Celcius)
        {
            return AstroMath.FourMethods.TempInKelvin(Celcius);
        }
        public double EventHorizon(double Blackholemass)
        {
            return AstroMath.FourMethods.EventHorizon(Blackholemass);
        }
    }
}

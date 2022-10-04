using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AstroMath
{
    public class FourMethods
    {
        public static double StarVelocity(double observedWavelength, double restWavelength)
        {
            // Change in Wavelength (Δλ) = Observed Wavelength – Rest Wavelength (λo).
            // Speed of Light (C) = 299792458 metres per second.
            // V = velocity in metres per second.
            // v = c * (Δλ / λo).
            double changeInWavelength = observedWavelength - restWavelength;
            int speedOfLight = 299792458;
            double starVelocityResult = speedOfLight * (changeInWavelength / restWavelength);
            return starVelocityResult;
        }
        public static double StarDistance(double arcsecondsAngle)
        {
            // Parallax Angle (P) in arcseconds (1 arcs = 1/3600).
            double P = arcsecondsAngle;
            double Distance = 1 / P; 
            return Distance;
        }
        public static double TempInKelvin(double Celcius)
        {
            //Temperature is Celsius (C) = a value must be greater than -273.
            // Temperature in Kelvin (K) = a value greater than zero.
            if (Celcius > -273)
            {
                return Celcius + 273;
            }
            else
            {
                
            }
            return Celcius;
        }
        public static double EventHorizon(double BlackholeMass)
        {
            // Event Horizon (Schwarzschild Radius): Create a method that will return the distance from the centre of a blackhole to the event horizon.
            return ((2 * (6.674 * Math.Pow(10,-11))) * BlackholeMass) / (Math.Pow(299792458, 2));  
        }

    }
}

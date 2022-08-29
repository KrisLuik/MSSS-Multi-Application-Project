using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AstroMath;
namespace TestDLL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //// Star Velocity.
            //Console.WriteLine("Enter Observed wavelength: ");
            //double observedWavelength = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Enter Rest Wavelength: ");
            //double restWavelength = Convert.ToDouble(Console.ReadLine());
            //Console.ReadLine();

            double result = 0;
            //result = AstroMath.FourMethods.StarVelocity(observedWavelength, restWavelength);
            //Console.WriteLine("Star Velocity " + Math.Ceiling(result) + " m/s.");
            
            //// Star Distance.
            //// Formula needs fixing.
            //Console.WriteLine("Enter Star Distance: ");
            //double starDistance = Convert.ToDouble(Console.ReadLine());
            //Console.ReadLine();
            //result = AstroMath.FourMethods.StarDistance(starDistance);
            //Console.WriteLine("Star Distance " + result + " parsec.");

            //// Temp in Kelvin.

            //Console.WriteLine("Enter Temperature in Celcius: ");
            //double tempInKelvin = Convert.ToDouble(Console.ReadLine());
            //Console.ReadLine();
            //result = AstroMath.FourMethods.TempInKelvin(tempInKelvin);
            //Console.WriteLine(result + " Degrees K.");

            // Event Horizon.
            // Fromula needs fixing. 

            Console.WriteLine("Enter Event Horizon: ");
            double eventHorizon = Convert.ToDouble(Console.ReadLine());
            Console.ReadLine();
            result = AstroMath.FourMethods.TempInKelvin(eventHorizon);
            Console.WriteLine("Event Horizon: " + result + " metres.");
            Console.ReadLine();
        }
    }
}

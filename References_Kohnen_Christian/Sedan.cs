using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace References_Kohnen_Christian
{
    class Sedan : IAutomobile  //implaments the elements from IAutomobile (Speed, Wheels< & LicensePlate)
    {
        public double Speed {get; private set;}

        public int Wheels {get; private set;}

        public string LicensePlate {get; private set;}

        public Sedan(double speed)  //creates a constructor that uses a double parameter
        {
            //assigns values to properties
            Wheels = 4;
            Speed = speed;
            LicensePlate = "GCTC-06";
        }

        public void Stringify()
        {
            Console.WriteLine($"The Sedan is traveling at the speed of {Speed} on {Wheels} with the License Plate number of {LicensePlate}");
            //creates a Stringify method that writes out the speed, # of wheels, and Licese Plate
        }

        public void IncreaseSpeed() //creates a method that increses the speed
        {
            Speed += 5;
        }
        public void DecreaseSpeed() //creates a method that decreases the speed
        {
            Speed -= 5;
        }
    }
}

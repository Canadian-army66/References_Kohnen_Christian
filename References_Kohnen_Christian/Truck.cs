using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace References_Kohnen_Christian
{
    class Truck : IAutomobile //implaments the elements from IAutomobile (Speed, Wheels< & LicensePlate)
    {
        public double Speed {get; private set;}

        public int Wheels {get; private set;}

        public string LicensePlate {get; private set;}

        public double Weight { get; } //creates a weight property

        public Truck(double speedParam, double weightParam, string licenceNum)  //creates a constructor that takes speedParam, weightParam, and LicenseNum)
        {
            Speed = speedParam;  //sets the speedParam to the Speed property
            Weight = weightParam;  //sets the weightParam to the Weight property
            LicensePlate = licenceNum;  //sets the licenseNum to the LicensePlate property

            if (Weight < 400)  //if the weight is under 400, the wheels are set to 8
            {
                Wheels = 8;
            }
            else  //if greater, the wheels are set to 12
            {
                Wheels = 12;
            }
        }

        public void Stringify()
        {
            Console.WriteLine($"The Truck is Traveling at the speed of {Speed} on {Wheels} wheels, with a License Plate of {LicensePlate}.");
            //creates a Stringify method that writes out the speed, # of wheels, and Licese Plate
        }

        public void IncreaseSpeed()  //creates a method that increses the speed
        {
            Speed += 5;
        }
        public void DecreaseSpeed()  //creates a method that decreases the speed
        {
            Speed -= 5;
        }
    }
}

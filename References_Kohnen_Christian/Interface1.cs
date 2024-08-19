using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace References_Kohnen_Christian
{
    internal interface IAutomobile
    {
        public double Speed { get; }  //makes a property with an Automatic getter

        public int Wheels { get; }  //makes a property with an Automatic getter

        public string LicensePlate { get; }  //makes a property with an Automatic getter

        public void Stringify();  //makes a method
    }
}

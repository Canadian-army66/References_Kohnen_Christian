using System;

namespace References_Kohnen_Christian
{
    class Program
    {
        static void Main(string[] args)
        {
            //creates myFirstSedan object and declares the IAutomobile object and assigns it to the Sedan
            Sedan myFirstSedan = new Sedan(0);
            IAutomobile myAutomobile = myFirstSedan;

            //creates myOtherSedan object
            Sedan myOtherSedan = new Sedan(0);

            //creates myTruck object
            Truck myTruck = new Truck(50, 500, "MyBaby");


            myFirstSedan.IncreaseSpeed();  //calls the speed up method to the object and myAutomobile object
            //prints the speed of the Sedan and the IAutomobile then compares them to see if equal
            Console.WriteLine(myFirstSedan.Speed);
            Console.WriteLine(myAutomobile.Speed);
            Console.WriteLine(myFirstSedan.Equals(myAutomobile));

            myOtherSedan.IncreaseSpeed(); //calls the speed up method to the object
            //prints the speed of the Sedan and the other Sedan then compares them to see if equal
            Console.WriteLine(myFirstSedan.Speed);
            Console.WriteLine(myOtherSedan.Speed);
            Console.WriteLine(myFirstSedan.Equals(myOtherSedan));

            //Calls stringify to describe automobiles
            myFirstSedan.Stringify();
            myAutomobile.Stringify();
            myOtherSedan.Stringify();
            myTruck.Stringify();
        }
    }
}
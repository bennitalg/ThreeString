using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreeString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the make of your car?");
            Console.Write("Type the make of your car: ");
            string myMakeCar;
            myMakeCar = Console.ReadLine();

            string myModelCar;
            Console.Write("Type the model of your car: ");
            myModelCar = Console.ReadLine();

            Console.WriteLine("My new car is a 2018 " + myMakeCar + " " + myModelCar.);
            Console.ReadLine();

        }
    }
}

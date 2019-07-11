using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            //Gretting for user
            Console.WriteLine("Welcome to Cylinder Calculator!");

            //Read cylinder's radius from user
            Console.WriteLine("Enter the cylinder's radius: ");
            string radiusAsAString = Console.ReadLine();
            double radius = Convert.ToDouble(radiusAsAString);

            //Read ub tge ctkubder's height from user
            Console.WriteLine("Enter the cylinder's height: ");
            string heightAsAString = Console.ReadLine();
            double height = Convert.ToDouble(heightAsAString);

            double pi = 3.141592654;

            //formulas for finding cylinder volume and surface area
            double volume = pi * radius * radius * height;
            double surfaceArea = 2 * pi * radius * (radius = height);

            //output results
            Console.WriteLine("The cylinder's volume is: " + volume + " cubic units.");
            Console.WriteLine("The cylinder's surface area is:  " + surfaceArea + " square units.");

            //wait for user input to close program
            Console.ReadLine();

            
        }
    }
}

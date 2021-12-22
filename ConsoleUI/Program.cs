using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
        
            var list = new List<Vehicle>();

            Car car1 = new Car()
            {
                Year = "2014",
                Make = "Ford",
                Model = "Explorer"
            };

            Motorcycle motorcycle1 = new Motorcycle()
            {
                Year = "2015",
                Make = "Yamaha",
                Model = "V Star"
            };

            Vehicle car2 = new Car()
            {
                Year = "2001",
                Make = "Toyota",
                Model = "Camery"
            };

            Vehicle car3 = new Car()
            {
                Year = "2016",
                Make = "Hyundai",
                Model = "Elantra"
            };

            list.Add(car1);
            list.Add(motorcycle1);
            list.Add(car2);
            list.Add(car3);

            foreach (var vehicle in list)
            {
                Console.WriteLine($"Year: {vehicle.Year}\n" +
                                  $"Make: {vehicle.Make}\n" +
                                  $"Model: {vehicle.Model}\n");
                Console.WriteLine();
            }

            Console.WriteLine();

            motorcycle1.DriveAbstract();
            motorcycle1.DriveVirtual();
            car1.DriveAbstract();
            car2.DriveAbstract();
           
            #region Vehicles

            /*
             * Create an abstract class called Vehicle
             * The vehicle class shall have three string properties Year, Make, and Model
             * Set the defaults to something generic in the Vehicle class
             * Vehicle shall have an abstract method called DriveAbstract with no implementation
             * Vehicle shall have a virtual method called DriveVirtual with a base implementation.
             */

            /* 
             * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
             * Add a distict property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
             * Provide the implementations for the abstract methods
             * Only in the Motorcycle class will you override the virtual drive method
            */

            // Create a list of Vehicle called vehicles

            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * - new it up as one of each derived class
             * Set the properties with object initializer syntax
             */

            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate over each of the properties
             */

            // Call each of the drive methods for one car and one motorcycle

            #endregion            
            Console.ReadLine();
        }
    }
}

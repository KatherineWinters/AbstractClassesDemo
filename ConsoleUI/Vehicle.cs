using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public abstract class Vehicle
    {
        public string Year { get; set; } = "2010";
        public string Make { get; set; } = "Honda";
        public string Model { get; set; } = "Ridgeline";

        public abstract void DriveAbstract();
        public virtual void DriveVirtual()
        {
            Console.WriteLine("Vehicles are a great way of transportation!");
        }



    }
}

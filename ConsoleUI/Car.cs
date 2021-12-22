using System;

namespace ConsoleUI
{
    public class Car : Vehicle
    {
        public bool HasBackUpCamera { get; set; }

        public override void DriveAbstract()
        {
            Console.WriteLine($"Drive a fancy pink car.");
        }

    }
}


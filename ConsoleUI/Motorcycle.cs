using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public class Motorcycle : Vehicle
    {
        public bool HasKickStand { get; set; }

        public override void DriveAbstract()
        {
            Console.WriteLine($"Always wear a helmet when riding a motorcycle.");
        }
        public override void DriveVirtual()
        {
            Console.WriteLine("Drive a motorcycle.");
        }
    }
}

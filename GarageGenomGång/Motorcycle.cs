using System;
using System.Collections.Generic;
using System.Text;

namespace GarageGenomGång
{
    public class Motorcycle: Vehicle
    {
        public int TopSpeed { get; set; }

        public Motorcycle(string aVehicleType, string aRegNum, string aColor, int aNumWheels, int aTopSpeed)
            : base(aVehicleType, aRegNum, aColor, aNumWheels)
        {
            TopSpeed = aTopSpeed;
        }
        public override string ToString()
        {
            return $"\nType of Vehicle: \t{VehicleType}\n" +
                $"Registration number: \t{RegNum}\n" +
                $"Color: \t\t\t{Color}\n" +
                $"Number of Wheels: \t{NumWheels}\n" +
                $"Top Speed motorcycle: \t{TopSpeed} kmh";
        }
    }
}

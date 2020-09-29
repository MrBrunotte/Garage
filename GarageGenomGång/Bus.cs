using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Schema;

namespace GarageGenomGång
{
    public class Bus : Vehicle
    {
        // add properity PascalCasing
        public int Length { get; private set; }

        public Bus(string aVehicleType, string aRegNum, string aColor, int aNumWheels, int aLength)
            : base(aVehicleType, aRegNum, aColor, aNumWheels)
        {
            Length = aLength;
        }
        public override string ToString()
        {
            return $"\nType of Vehicle: \t{VehicleType}\n" +
                $"Registration number: \t{RegNum}\n" +
                $"Color: \t\t\t{Color}\n" +
                $"Number of Wheels: \t{NumWheels}\n" +
                $"Bus Length: \t\t{Length} meters";
        }
    }
}

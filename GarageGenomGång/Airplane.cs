using System;
using System.Collections.Generic;
using System.Text;

namespace GarageGenomGång
{
    // is public and inherits from Vehicle
    class Airplane : Vehicle
    {
        // Dont add the properties from Vehcile, they are inherited!
        public int NumWings { get; private set; }

        public Airplane(string aVehicleType, string aRegNum, string aColor, int aNumWheels, int aNumWings)
            : base(aVehicleType, aRegNum, aColor, aNumWheels)
        {
            NumWings = aNumWings;
        }
        public override string ToString()
        {
            // properties in base class needs to be public to be accessed
            return $"\nType of Vehicle: \t{VehicleType}\n" +
                $"Registration number: \t{RegNum}\n" +
                $"Color: \t\t\t{Color}\n" +
                $"Number of Wheels: \t{NumWheels}\n" +
                $"Number of Wings: \t{NumWings}";
        }
    }
}

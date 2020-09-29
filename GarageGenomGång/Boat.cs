using System;
using System.Collections.Generic;
using System.Text;

namespace GarageGenomGång
{
    class Boat : Vehicle
    {
        // Properties PascalCase naming
        public string FuelType { get; set; }

        // Constructor for Boat
        public Boat(string aVehicleType, string aRegNum, string aColor, int aNumWheels, string aFuelType)
            : base(aVehicleType, aRegNum, aColor, aNumWheels)
        {
            FuelType = aFuelType;
        }
        public override string ToString()
        {
            return $"\nType of Vehicle: \t{VehicleType}\n" +
                $"Registration number: \t{RegNum}\n" +
                $"Color: \t\t\t{Color}\n" +
                $"Fuel type: \t\t{FuelType}";
        }
    }
}

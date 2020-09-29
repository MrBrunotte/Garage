using System;
using System.Collections.Generic;
using System.Text;

namespace GarageGenomGång
{
    public class Vehicle
    {
        // Fält behövs ej! 
        // string _regNum;
        // string _color;
        // int _wheelCount;

        // set properties for all kinds of vehicle they all share these properties
        // Properties naming convention PascalCase
        public string VehicleType { get; set; }
        public string RegNum { get; set; } 
        public string Color { get; set; }
        public int NumWheels { get; set; }

        // set constructor so when instantiating a vehicle object the properties
        // needs to be passed in
        public Vehicle(string aVehicleType, string aRegNum, string aColor, int aNumWheels)
        {
            VehicleType = aVehicleType.ToUpper();
            RegNum = aRegNum.ToUpper(); // this.regNum = aRegNum;
            Color = aColor;
            NumWheels = aNumWheels;
        }

        public override string ToString()
        {
            return $"\nType of Vehicle: \t{VehicleType}\n" +
                $"Registration number: \t{RegNum}\n" +
                $"Color: \t\t\t{Color}\n" +
                $"Number of Wheels: \t{NumWheels}";
        }
    }
}

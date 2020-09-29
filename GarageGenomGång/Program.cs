using System;
using System.Drawing;

namespace GarageGenomGång
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle vehicle = new Vehicle("Base Vehicle", "123abc", "black", 4);
            Airplane airplane = new Airplane("Airplane", "123edf", "White", 10, 4);
            Boat boat = new Boat("Boat", "1234ghi", "black", 0, "Diesel");
            Bus bus = new Bus("Bus", "123jkl", "blue", 10, 5);
            Car car = new Car("Car", "123jop", "red", 4, 350);
            Motorcycle motorcycle = new Motorcycle("Motorcycle", "456jkl", "black", 2, 390);
            Console.WriteLine(vehicle.ToString());
            Console.WriteLine(airplane.ToString());
            Console.WriteLine(boat.ToString());
            Console.WriteLine(bus.ToString());
            Console.WriteLine(car.ToString());
            Console.WriteLine(motorcycle.ToString());

        }
    }
}

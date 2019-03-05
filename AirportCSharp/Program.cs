using System;
using AirportCSharp.ClassLibraries;

namespace AirportCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Airport airport = new Airport();
            Plane plane1 = new Plane();
            Plane plane2 = new Plane();
            Plane plane3 = new Plane();
            Console.WriteLine(plane1.flightNumber);
            Console.WriteLine(plane2.flightNumber);
            Console.WriteLine(plane3.flightNumber);
            airport.Land(plane1);
            airport.Land(plane2);
            airport.Land(plane3);
            var planeCheck = airport.planes[0];
            Console.WriteLine(airport.weather);
        }
    }
}

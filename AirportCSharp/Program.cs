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
            Console.WriteLine(airport.planes);
        }
    }
}

using System;

namespace AirportCSharp.ClassLibraries
{
    public class Plane
    {
        public bool flying = false;
        public int flightNumber { get; set; }

        public Plane()
        {
            flightNumber = randomRoll();
        }

        private int randomRoll()
        {
            Random rnd = new Random();
            int roll = rnd.Next(100, 999);
            return roll;
        }
    }
}

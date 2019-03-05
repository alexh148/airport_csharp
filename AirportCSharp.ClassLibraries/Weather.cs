using System;
namespace AirportCSharp.ClassLibraries
{
    public class Weather
    {
        public bool SafeToLand { get; set; }

        public Weather()
        {
            SafeToLand = Safe(RandomRoll());
        }

        public int RandomRoll()
        {
            Random rnd = new Random();
            int roll = rnd.Next(1, 10);
            return roll;
        }

        public bool Safe(int roll)
        {
            if (roll > 2) { return true; }
            return false;
        }

        public bool IsStormy()
        {
            return false;
        }
    }
}
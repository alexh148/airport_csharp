using System;
namespace AirportCSharp.ClassLibraries
{
    public class Weather
    {
        public static int randomRoll()
        {
            Random rnd = new Random();
            int roll = rnd.Next(1, 10);
            return roll;
        }

        public static string assignWeather(int roll)
        {
            if (roll > 2) { return "Sunny"; }
            return "Stormy";
        }
    }
}
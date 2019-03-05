using System;
using AirportCSharp.ClassLibraries;
using NUnit.Framework;

namespace AirportCSharp.UnitTests
{
    [TestFixture]
    public class WeatherTests
    {
        [TestCase(1, "Stormy")]
        [TestCase(2, "Stormy")]
        [TestCase(9, "Sunny")]
        [TestCase(10, "Sunny")]
        public void Returns_Sunny_Or_Stormy(int input, String output)
        {
            String weather = Weather.assignWeather(input);
            Assert.That(weather, Is.EqualTo(output));

        }
    }
}
using System;
using AirportCSharp.ClassLibraries;
using NUnit.Framework;

namespace AirportCSharp.UnitTests
{
    [TestFixture]
    public class WeatherTests
    {
        [TestCase(1, false)]
        [TestCase(2, false)]
        [TestCase(9, true)]
        [TestCase(10, true)]
        public void Returns_Sunny_Or_Stormy(int input, bool output)
        {
            // Arrange
            Weather weather = new Weather();

            // Act
            bool safeWeather = weather.Safe(input);

            // Assert
            Assert.That(safeWeather, Is.EqualTo(output));
        }
    }
}
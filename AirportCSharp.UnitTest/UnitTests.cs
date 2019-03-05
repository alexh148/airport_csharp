using System;
using System.Collections;
using Moq;
using AirportCSharp.ClassLibraries;
using NUnit.Framework;

namespace AirportCSharp.UnitTests
{
    [TestFixture]
    public class AirportTests
    {
        [Test]
        public void LandPlane()
        {
            // Arrange
            Mock<Plane> testPlane = new Mock<Plane>();
            Mock<Weather> weather = new Mock<Weather>();
            Airport airport = new Airport(weather.Object);

            // Act
            airport.Land(testPlane.Object);

            // Assert
            CollectionAssert.Contains(airport.planes, testPlane.Object);
        }

        [Test]
        public void TakeOff()
        {
            //Arrange
            Mock<Plane> testPlane = new Mock<Plane>();
            Mock<Weather> weather = new Mock<Weather>();
            Airport airport = new Airport(weather.Object);

            //Act
            airport.Land(testPlane.Object);
            airport.TakeOff(testPlane.Object);

            //Assert
            CollectionAssert.DoesNotContain(airport.planes, testPlane.Object);
        }

        [Test]
        public void MaxCapacity()
        {
            // Arrange
            Mock<Plane> testPlane = new Mock<Plane>();
            Mock<Weather> weather = new Mock<Weather>();
            Airport airport = new Airport(weather.Object);

            // Act
            for (int i = 0; i < airport.capacity; i++)
            {
                airport.Land(testPlane.Object);
            }

            //Assert
            Assert.That(() => airport.Land(testPlane.Object),
               Throws.TypeOf<InvalidOperationException>());
        }

        [Test]
        public void CantActInStormyWeather()
        {
            // Arrange
            Mock<Plane> testPlane = new Mock<Plane>();
            Mock<Weather> weather = new Mock<Weather>();
            weather.Setup(x => x.IsNotSafe()).Returns(true);
            Airport airport = new Airport(weather.Object);

            // Act * Assert
            Assert.That(() => airport.Land(testPlane.Object),
            Throws.TypeOf<InvalidOperationException>());
            Assert.That(() => airport.TakeOff(testPlane.Object),
            Throws.TypeOf<InvalidOperationException>());
        }
    }
}
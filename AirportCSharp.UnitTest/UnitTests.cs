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
            var testPlane = new Mock<Plane>();
            Airport airport = new Airport();
            airport.Land(testPlane.Object);
            Console.Write(airport.planes[0]);
            CollectionAssert.Contains(airport.planes, testPlane.Object);
        }
        [Test]
        public void MaxCapacity()
        {
            Airport airport = new Airport();
            var testPlane = new Mock<Plane>();
            for (int i = 0; i < airport.capacity; i++)
            {
                airport.Land(testPlane.Object);
            }
            Assert.That(() => airport.Land(testPlane.Object),
               Throws.TypeOf<InvalidOperationException>());
        }
        [Test]
        public void TakeOff()
        {
            var testPlane = new Mock<Plane>();
            Airport airport = new Airport();
            airport.Land(testPlane.Object);
            airport.TakeOff(testPlane.Object);
            CollectionAssert.DoesNotContain(airport.planes, testPlane.Object);
        }
        //[Test]
        //public void AttemptingToLandInStormyWeather()
        //{
            //Airport airport = new Airport();
            //var testPlane = new Mock<Plane>();
            //Mock<Weather> weather = new Mock<Weather>();
            //weather.Setup(x => x.IsStormy()).Returns(true);
            //Assert.That(() => airport.Land(testPlane.Object),
            //Assert.That(Weather.IsStormy()).Returns(false);
                //Throws.TypeOf<InvalidOperationException>());
                // }
    }
}

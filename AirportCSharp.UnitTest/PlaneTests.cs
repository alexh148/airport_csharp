using System;
using AirportCSharp.ClassLibraries;
using NUnit.Framework;

namespace AirportCSharp.UnitTests
{
    [TestFixture]
    public class PlaneTests
    {
        [Test]
        public void WhenInitialized_IsntFlying()
        {
            // Arrange
            Plane plane = new Plane();

            // Assert
            Assert.False(plane.flying);
        }
    }
}

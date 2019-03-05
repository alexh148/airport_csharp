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
            Plane plane = new Plane();
            Assert.False(plane.flying);
        }
    }
}

using System;
using AirportCSharp.ClassLibraries;
using NUnit.Framework;

namespace AirportCSharp.UnitTests
{
    [TestFixture]
    public class AirportTests
    {
        [Test]
        public void WhenInitialized_HasCapacity()
        {
            Airport airport = new Airport();
            Array arr = airport.planes;
            int length = arr.Length;
            Assert.AreEqual(20, length);
        }
    }
}

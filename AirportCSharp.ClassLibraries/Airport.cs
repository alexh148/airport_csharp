using System;
using System.Collections;

namespace AirportCSharp.ClassLibraries
{
    public class Airport
    {
        public ArrayList planes = new ArrayList();
        public int capacity = 20;
        public String weather = Weather.assignWeather(Weather.randomRoll());

        public void Land(Plane thisPlane)
        { 
            if (planes.Count == capacity)
            {
                throw new InvalidOperationException("Airport Is Full");
            }
            planes.Add(thisPlane);
        }
        public void TakeOff(Plane thisPlane)
        {
            planes.Remove(thisPlane);
        }
    }
}



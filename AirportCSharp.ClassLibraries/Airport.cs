using System;
using System.Collections;

namespace AirportCSharp.ClassLibraries
{
    public class Airport
    {
        public ArrayList planes;
        public int capacity;
        public Weather weather;

        // Constructors
        public Airport()
        {
            planes = new ArrayList();
            capacity = 20;
            weather = new Weather();

        }
        public Airport(int capa)
        {
            planes = new ArrayList();
            capacity = capa;
            weather = new Weather();
        }

        public Airport(Weather thisWeather)
        {
            planes = new ArrayList();
            capacity = 20;
            weather = thisWeather;
        }

        // Instance Methods
        public void Land(Plane thisPlane)
        { 
            if (planes.Count == capacity)
            {
                throw new InvalidOperationException("Airport is Full, cannot Land");
            }
            if (weather.IsNotSafe())
            {
                throw new InvalidOperationException("Weather is Stormy, cannot Land");
            }
            planes.Add(thisPlane);
        }

        public void TakeOff(Plane thisPlane)
        {
            if (weather.IsNotSafe())
            {
                throw new InvalidOperationException("Weather is Stormy, cannot Take Off");
            }
            planes.Remove(thisPlane);
        }

    }
}



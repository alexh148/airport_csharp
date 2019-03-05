using System;
using System.Collections;

namespace AirportCSharp.ClassLibraries
{
    public class Airport
    {
        public ArrayList planes;
        public int capacity;
        public Weather weather;

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



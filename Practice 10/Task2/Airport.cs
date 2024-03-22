using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Airport
    {
        private Airplane[] airplanes;

        public Airport(Airplane[] airplanes)
        {
            this.airplanes = airplanes;
        }

        public Airplane this[int flightNumber]
        {
            get
            {
                return airplanes.FirstOrDefault(a => a.FlightNumber == flightNumber);
            }
        }

        public void SortByDestination()
        {
            Array.Sort(airplanes, (a1, a2) => a1.Destination.CompareTo(a2.Destination));
        }

        public void SortByFlightNumber()
        {
            Array.Sort(airplanes, (a1, a2) => a1.FlightNumber.CompareTo(a2.FlightNumber));
        }
    }
}
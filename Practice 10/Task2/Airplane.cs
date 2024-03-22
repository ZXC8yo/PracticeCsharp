using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Airplane
    {
        private string destination;
        private int flightNumber;
        private DateTime departureTime;

        public string Destination
        {
            get { return destination; }
            set { destination = value; }
        }

        public int FlightNumber
        {
            get { return flightNumber; }
            set { flightNumber = value; }
        }

        public DateTime DepartureTime
        {
            get { return departureTime; }
            set { departureTime = value; }
        }

        public Airplane(string destination, int flightNumber, DateTime departureTime)
        {
            this.destination = destination;
            this.flightNumber = flightNumber;
            this.departureTime = departureTime;
        }

        public override string ToString()
        {
            return $"Место назначения: {destination}, Номер полета: {flightNumber}, Время отправления: {departureTime}";
        }
    }
}
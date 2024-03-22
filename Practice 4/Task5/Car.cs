using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Car
    {
        public string LicensePlate { get; set; }
        public string Color { get; set; }
        public string Owner { get; set; }
        public bool IsParked { get; set; }

        public Car(string licensePlate, string color, string owner, bool IsParking)
        {
            LicensePlate = licensePlate;
            Color = color;
            Owner = owner;
            IsParked = IsParking;
        }
    }
}

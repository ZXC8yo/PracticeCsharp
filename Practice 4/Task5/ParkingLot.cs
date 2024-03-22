using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class ParkingLot
    {
        public List<Car> cars { get; set; }

        public ParkingLot()
        {
            cars = new List<Car>();
        }

        public void ParkCar(Car car)
        {
            car.IsParked = true;
            cars.Add(car);
        }

        public void RemoveCar(Car car)
        {
            car.IsParked = false;
            cars.Remove(car);
        }

        public Car FindCarByLicensePlate(string licensePlate)
        {
            return cars.Find(car => car.LicensePlate == licensePlate);
        }

        public List<Car> GetParkedCars()
        {
            return cars.FindAll(car => car.IsParked);
        }

        public List<Car> GetUnparkedCars()
        {
            
            return cars.FindAll(car => !car.IsParked);
        }

        public Car GetCarByIndex(int index)
        {
            if (index >= 0 && index < cars.Count)
            {
                return cars[index];
            }
            return null;
        }
    }
}

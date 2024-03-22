using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ParkingLot parkingLot = new ParkingLot();

            Car car1 = new Car("ABC123", "Красный", "Маск",true);
            Car car2 = new Car("XYZ789", "Серебристый", "Сильверхенд",true);
            Car car3 = new Car("DEF456", "Зеленый", "Медрано",false);

            parkingLot.ParkCar(car1);
            parkingLot.ParkCar(car2);
            parkingLot.ParkCar(car3);

            Car foundCar = parkingLot.FindCarByLicensePlate("ABC123");
            if (foundCar != null)
            {
                Console.WriteLine("Поиск машины: " + foundCar.Color + " " + foundCar.LicensePlate);
            }

            List<Car> parkedCars = parkingLot.GetParkedCars();
            Console.WriteLine("Припаркованные авто:");
            foreach (Car car in parkedCars)
            {
                Console.WriteLine(car.Color + " " + car.LicensePlate);
            }

           
            List<Car> unparkedCars = parkingLot.GetUnparkedCars();
            Console.WriteLine("Не припаркованные авто:");
            foreach (Car car in unparkedCars)
            { 
                    Console.WriteLine(car.Color + " " + car.LicensePlate);
                
            }

            Car carAtIndex = parkingLot.GetCarByIndex(1);
            if (carAtIndex != null)
            {
                Console.WriteLine("Авто с индексом 1: " + carAtIndex.Color + " " + carAtIndex.LicensePlate);
            }
        }
    }
}


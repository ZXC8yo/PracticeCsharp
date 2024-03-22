using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Airplane[] airplanes = new Airplane[]
        {
            new Airplane("Догестан", 123456, new DateTime(2024, 3, 1, 10, 0, 0)),
            new Airplane("Готем", 654321, new DateTime(2024, 3, 1, 12, 0, 0)),
            new Airplane("Найт Сити", 987654, new DateTime(2077, 3, 1, 14, 0, 0)),
        };

            Airport airport = new Airport(airplanes);


            int flightNumber = 654321;
            Airplane airplane = airport[flightNumber];
            if (airplane != null)
            {
                Console.WriteLine($"Найденный самолёт - {airplane}");
            }
            else
            {
                Console.WriteLine($"Самолет с номером рейса{flightNumber} не найден.");
            }


            airport.SortByDestination();

            Console.WriteLine("Отсортированный список самолётов:");

            foreach (Airplane plane in airplanes)
            {
                Console.WriteLine(plane);
            }
        }
    }

}
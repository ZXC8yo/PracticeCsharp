using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    /// <summary>
    /// Представляет парковку.
    /// </summary>
    class ParkingLot
    {
        /// <summary>
        /// Список автомобилей на парковке.
        /// </summary>
        public List<Car> Cars { get; set; }

        /// <summary>
        /// Инициализирует новый экземпляр класса ParkingLot.
        /// </summary>
        public ParkingLot()
        {
            Cars = new List<Car>();
        }

        /// <summary>
        /// Припарковать автомобиль.
        /// </summary>
        /// <param name="car">Автомобиль для парковки.</param>
        public void ParkCar(Car car)
        {
            car.IsParked = true;
            Cars.Add(car);
        }

        /// <summary>
        /// Убрать автомобиль с парковки.
        /// </summary>
        /// <param name="car">Автомобиль для удаления с парковки.</param>
        public void RemoveCar(Car car)
        {
            car.IsParked = false;
            Cars.Remove(car);
        }

        /// <summary>
        /// Найти автомобиль по государственному номеру.
        /// </summary>
        /// <param name="licensePlate">Государственный номер автомобиля.</param>
        /// <returns>Найденный автомобиль или null, если автомобиль не найден.</returns>
        public Car FindCarByLicensePlate(string licensePlate)
        {
            return Cars.Find(car => car.LicensePlate == licensePlate);
        }

        /// <summary>
        /// Получить список припаркованных автомобилей.
        /// </summary>
        /// <returns>Список припаркованных автомобилей.</returns>
        public List<Car> GetParkedCars()
        {
            return Cars.FindAll(car => car.IsParked);
        }

        /// <summary>
        /// Получить список неприпаркованных автомобилей.
        /// </summary>
        /// <returns>Список неприпаркованных автомобилей.</returns>
        public List<Car> GetUnparkedCars()
        {
            return Cars.FindAll(car => !car.IsParked);
        }

        /// <summary>
        /// Получить автомобиль по индексу.
        /// </summary>
        /// <param name="index">Индекс автомобиля.</param>
        /// <returns>Автомобиль с указанным индексом или null, если индекс выходит за пределы списка.</returns>
        public Car GetCarByIndex(int index)
        {
            if (index >= 0 && index < Cars.Count)
            {
                return Cars[index];
            }
            return null;
        }
    }
}

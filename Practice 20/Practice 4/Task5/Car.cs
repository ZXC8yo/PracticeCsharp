using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    /// <summary>
    /// Представляет автомобиль.
    /// </summary>
    class Car
    {
        /// <summary>
        /// Получает или задает государственный номер автомобиля.
        /// </summary>
        public string LicensePlate { get; set; }

        /// <summary>
        /// Получает или задает цвет автомобиля.
        /// </summary>
        public string Color { get; set; }

        /// <summary>
        /// Получает или задает владельца автомобиля.
        /// </summary>
        public string Owner { get; set; }

        /// <summary>
        /// Получает или задает значение, указывающее, припаркован ли автомобиль.
        /// </summary>
        public bool IsParked { get; set; }

        /// <summary>
        /// Инициализирует новый экземпляр класса Car с указанными параметрами.
        /// </summary>
        /// <param name="licensePlate">Государственный номер автомобиля.</param>
        /// <param name="color">Цвет автомобиля.</param>
        /// <param name="owner">Владелец автомобиля.</param>
        /// <param name="isParked">Значение, указывающее, припаркован ли автомобиль.</param>
        public Car(string licensePlate, string color, string owner, bool isParked)
        {
            LicensePlate = licensePlate;
            Color = color;
            Owner = owner;
            IsParked = isParked;
        }
    }
}

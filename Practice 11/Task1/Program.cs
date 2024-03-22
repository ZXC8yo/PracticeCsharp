using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Phone phone = new Phone("Iphone", 9568);
            phone.DisplayFields();
            Console.WriteLine($"Стоимость: {phone.CalculaeCash()}");

            Console.WriteLine();
            CellPhone cellPhone = new CellPhone("Huawei", 25, "Galaxy");
            cellPhone.DisplayFields();
            Console.WriteLine($"Стоимость: {cellPhone.CalculateCash()}");

        }
    }
}
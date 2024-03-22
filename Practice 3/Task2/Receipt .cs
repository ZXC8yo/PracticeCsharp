using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Receipt:Document
    {
        public string CustomerName { get; set; }
        public decimal TotalAmount { get; set; }

        public  void PrintReceipt()
        {
            Console.WriteLine($"Костюмер: {CustomerName}");
            Console.WriteLine($"Тотальная сумма: {TotalAmount}");
        }
    }
}

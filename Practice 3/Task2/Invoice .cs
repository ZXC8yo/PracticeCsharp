using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Invoice:Document
    {
        public string VendorName { get; set; }
        public decimal TotalAmount { get; set; }

        public void ShowDocument()
        {
            Console.WriteLine($"Поставщик: {VendorName}");
            Console.WriteLine($"Тотальная сумма: {TotalAmount}");
        }
    }
}

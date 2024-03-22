using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Bill:Document
    {
        public string CompanyName { get; set; }
        public int AmountDue { get; set; }

        public void ShowBill()
        {
            
            Console.WriteLine($"Имя компании: {CompanyName}");
            Console.WriteLine($"Сумма: {AmountDue}");
        }
    }
}

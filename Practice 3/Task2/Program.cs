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
            Receipt receipt = new Receipt()
            {
                  Title = "Рецепт",
                  Date = DateTime.Now,
                  CustomerName = "Джонни",
                  TotalAmount = 100
            };

            Invoice invoice = new Invoice()
            {
                Title = "Счет",
                Date = DateTime.Now,
                VendorName = "Корпараты",
                TotalAmount = 500
            };

            Bill bill = new Bill()
            {
                Title = "Законопроект",
                Date = DateTime.Now,
                CompanyName = "Арасака",
                AmountDue = 1000
            };

            receipt.ShowDocument();
            Console.WriteLine();
            invoice.ShowDocument();
            Console.WriteLine();
            bill.ShowBill();

            Console.ReadLine();
        }
    }
}

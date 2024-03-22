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
            List<Magazine> listPrintedProducts = new List<Magazine>();
            List<Newspaper> secondListPrintedProducts = new List<Newspaper>();

            Magazine magazine1 = new Magazine("Playboy", 69, 8);
            Magazine magazine2 = new Magazine("Forbs", 42, 5);
            Magazine magazine3 = new Magazine("Victoria Secret", 16, 16);

            Newspaper newspaper1 = new Newspaper("The Sun", 32, 17, 3);
            Newspaper newspaper2 = new Newspaper("The New York Times", 67, 25, 4);

            listPrintedProducts.Add(magazine1);
            listPrintedProducts.Add(magazine2);
            listPrintedProducts.Add(magazine3);
            secondListPrintedProducts.Add(newspaper1);
            secondListPrintedProducts.Add(newspaper2);


            double avarageForMagazin = 0;
            double avarageForNewspaper = 0;
            foreach (var list in listPrintedProducts)
            {
                Console.WriteLine($"Стоимость тиража журнала {list.Name}: {list.GetPrice()}"); ;
                Console.WriteLine();
            }

            foreach (var list in secondListPrintedProducts)
            {
                Console.WriteLine($"Стоимость тиража газеты {list.Name}: {list.GetPrice()}");
                Console.WriteLine();
            }


            foreach (var list in listPrintedProducts)
            {
                avarageForMagazin += list.GetPrice();
                
            }

            foreach (var list in secondListPrintedProducts)
            {
                avarageForNewspaper += list.GetPrice();

            }

            Console.WriteLine($"Средняя стоимость журналов {avarageForMagazin / listPrintedProducts.Count}");
            Console.WriteLine($"Средняя стоимость газет {avarageForNewspaper / secondListPrintedProducts.Count}");
        }
    }
}

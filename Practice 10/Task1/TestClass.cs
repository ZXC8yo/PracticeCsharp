﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class TestClass : Ix, Iy, Iz
    {
        public int w;


        public void IxF0(int parameter)
        {
            Console.WriteLine($"Интерфейс Ix  метод F0:{Math.Pow(parameter, 2) - parameter}");
        }

        public void IxF1()
        {
            Console.WriteLine("IxF1");
        }

        public void F0(int parameter)
        {
            Console.WriteLine($"метод F0:{15 / parameter}");
        }

        public void F1()
        {
            Console.WriteLine("F1");
        }


        void Iz.F0(int parameter)
        {
            Console.WriteLine($"Интерфейс Iz  метод F0:{2 * parameter - 3}");
        }

        void Iz.F1()
        {
            Console.WriteLine("IzF1:");
        }
    }
}
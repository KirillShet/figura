using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class rectangle1
    {
        private float a;
        private float b;
        private float S;
        private float P;
        private bool pov;
        public void info()
        {
            Console.WriteLine("Введите сторону фигуры.");
            a = float.Parse(Console.ReadLine());
            b = float.Parse(Console.ReadLine());
        }
        private bool prov()
        {
            if (a > 0 && b > 0)
            {
                pov = true; return pov;
            }
            else
            {
                pov = false; return pov;
            }
        }
        private float perimeter()
        {
            P = (a + b) * 2;
            return P;
        }
        private float square()
        {
            S = a * b;
            return S;
        }
        public void out_info()
        {
            if (prov() == true)
            {
                Console.WriteLine("Периметр фигуры: " + perimeter());
                Console.WriteLine("Площадь фигуры: " + square());
            }
            else
            {
                Console.WriteLine("Вы ввели неправильное число.");
            }
        }
    }
}
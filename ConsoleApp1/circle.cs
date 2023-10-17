using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class circle1
    {
        private float r;
        private float S;
        private float P;
        private bool pov;
        public void info()
        {
            r = float.Parse(Console.ReadLine());
        }
        private bool prov()
        {
            if (r > 0)
            {
                pov = true; return pov;
            }
            else { pov = false; return pov; }
        }
        private float square()
        {
                S = (float)Math.PI * (float)Math.Pow(r, 2);
                return S;
        }
        private float perimeter()
        {
                P = 2 * (float)Math.PI * r;
                return P;
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

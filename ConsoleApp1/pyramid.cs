using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class pyramid
    {
        private float n;
        private float r;
        private float h;
        private float a;
        private float Ap;
        private int change;
        private float S;
        private float P;
        private float V;
        private float result;
        private bool pov;

        public void info()
        {
            Console.WriteLine("Введите высоту пирамиды.");
            h = float.Parse(Console.ReadLine());
            Console.WriteLine("Введите, какое должно быть основание: круг - 1 или n-угольник - 2");
            change = Convert.ToInt32(Console.ReadLine());
            if (change == 2)
            {
                Console.WriteLine("Введите количество углов многоугольника.");
                n = float.Parse(Console.ReadLine());
                Console.WriteLine("Введите длинну стороны основания.");
                a = float.Parse(Console.ReadLine());
            }
            else if (change == 1)
            {
                Console.WriteLine("Введите радиус круга.");
                r = float.Parse(Console.ReadLine());
            }
        }
        private bool prov()
        {
            if ((n > 2 && h > 0 && a > 0) || (r > 0 && h > 0))
            {
                pov = true;
                return pov;
            }
            else
            {
                return pov;
            }
        }
        private float vich()
        {
            if (n == 3)
            {
                V = (float)(h * Math.Pow(a, 2)) / (float)(4 * Math.Sqrt(3));
                return V;
            }
            else if (n == 4)
            {
                V = (float)(h * Math.Pow(a, 2)/3);
                return V;
            }
            else if (n == 6)
            {
                V = (float)(Math.Sqrt(3) / 2) * (float)(h * Math.Pow(a, 2));
                return V;
            }
            else
            {
                V = (float)(n * h * Math.Pow(a, 2)) / (float)(12 * Math.Tan(Math.PI / n));
                return V;
            }
        }
        private float A()
        {
            Ap = a / (float)(2 * Math.Tan(Math.PI / n));
            return Ap;
        }
        private float square()
        {
            S = (float)((a * A() * n) / 2) + (float)((a * n * Math.Sqrt(Math.Pow(h, 2) + Math.Pow(A(), 2))) / 2);
            return S;
        }
        private float perimeter()
        {
            P = (a * n) + ((float)(Math.Sqrt(Math.Pow(h, 2) + Math.Pow(A(), 2))) * n);
            return P;
        }
        private float vich2()
        {
            V = (float)(Math.PI * Math.Pow(r, 2) * h) / 3;
            return V;
        }
        private float square2()
        {
            S = (float)Math.PI * r * (float)Math.Sqrt(Math.Pow(h, 2) + Math.Pow(r, 2)) + (float)Math.PI * (float)Math.Pow(r, 2);
            return S;
        }
        private float perimeter2()
        {
            P = (float)(Math.PI * 2 * r);
            return P;
        }
        public void out_info()
        {
            if (prov() == true)
            {
                if (change == 2)
                {
                    Console.WriteLine("Периметр пирамидки: " + perimeter());
                    Console.WriteLine("Площадь пирамидки: " + square());
                    Console.WriteLine("Объем пирамиды равен: " + vich());
                }
                else if (change == 1)
                {
                    Console.WriteLine("Периметр пирамидки: " + perimeter2());
                    Console.WriteLine("Площадь пирамидки: " + square2());
                    Console.WriteLine("Объем пирамиды равен: " + vich2());
                }
            }
            else
            {
                Console.WriteLine("Вы ввели неправильное число");
            }
        }
    }
}
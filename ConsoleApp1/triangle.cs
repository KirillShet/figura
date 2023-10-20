using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class triangle1
    {
        private float a;
        private float b;
        private float c;
        private float x;
        private float S;
        private float P;
        private float p;
        private bool pov;
        public void info()
        {
            Console.WriteLine("Введите сторону фигуры.");
            a = float.Parse(Console.ReadLine());
            b = float.Parse(Console.ReadLine());
            c = float.Parse(Console.ReadLine());
            if (a > b)
            {
                if (a > c)
                { x = a; a = c; c = x; }
            }
            else if (b > a)
            {
                if (b > c)
                { x = b; b = c; c = x; }
            }
        }
        private bool prov()
        {
            if ((a + b) > c && (a + c) > b && (b + c) > a && a > 0 && b > 0 && c > 0)
            { pov = true; return pov; }
            else
            { pov = false; return pov; }
        }
        private void type()
        {
            if (Math.Pow(c, 2) == (Math.Pow(a, 2) + Math.Pow(b, 2)))
            {
                Console.WriteLine("Треугольник прямоугольный");
            }
            if (Math.Pow(c, 2) > (Math.Pow(a, 2) + Math.Pow(b, 2)))
            {
                Console.WriteLine("Треугольник тупоугольный");
            }
            if (Math.Pow(c, 2) < (Math.Pow(a, 2) + Math.Pow(b, 2)))
            {
                Console.WriteLine("Треугольник остроугольный");
            }
            if (a != c && a != b && b != c)
            {
                Console.WriteLine("Треугольник разносторонний");
            }
            if (a == b && a == c && c == b)
            {
                Console.WriteLine("Треугольник равносторонний");
            }
            else if (a == b || b == c || a == c)
            {
                Console.WriteLine("Треугольник равнобедренный");
            }
        }
        public void vivod()
        {
            if (prov() == false)
            {
                Console.WriteLine("Такого треугольника не существует.");
            }
            else
            {
                type();
                perimeter();
                square();
            }
        }
        private float perimeter()
        {
            P = a + b + c;
            return P;
        }
        private float square()
        {
            S = (float)Math.Sqrt(perimeter() / 2 * (perimeter() / 2 - a) * (perimeter() / 2 - b) * (perimeter() / 2 - c));
            Console.WriteLine("Периметр фигуры: " + P);
            Console.WriteLine("Площадь фигуры: " + S);
            return S;
        }
    }
}
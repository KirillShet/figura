using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class square
    {
        public float a;
        public float b;
        public float S;
        public float P;
        public void info()
        {
            Console.WriteLine("Введите сторону фигуры.");
            a = float.Parse(Console.ReadLine());
        }
        public float perimeter()
        {
            P = a * 4;
            Console.WriteLine("Периметр фигуры: "+P);
            return P;
        }
        public float Square()
        {
            S = (float)Math.Pow(a, 2);
            Console.WriteLine("Площадь фигуры: "+S);
            return S;
        }
    }
    internal class rectangle
    {
        public float a;
        public float b;
        public float S;
        public float P;
        public void info()
        {
            Console.WriteLine("Введите сторону фигуры.");
            a = float.Parse(Console.ReadLine());
            b = float.Parse(Console.ReadLine());
        }
        public float perimeter()
        {
            P = (a + b) * 2;
            Console.WriteLine("Периметр фигуры: "+P);
            return P;
        }
        public float square()
        {
            S = a*b;
            Console.WriteLine("Площадь фигуры: " + S);
            return S;
        }
    }
    internal class triangle
    {
        public float a;
        public float b;
        public float c;
        public float S;
        public float P;
        public float p;
        public bool pov;
        public void info()
        {
            Console.WriteLine("Введите сторону фигуры.");
            a = float.Parse(Console.ReadLine());
            b = float.Parse(Console.ReadLine());
            c = float.Parse(Console.ReadLine());
        }

        public bool prov()
        {
            if ((a + b) > c && (a + c) > b && (b + c) > a)
            {
                pov = true;
                return pov;
            }
            else
            {
                pov = false;
                return pov;
            }
        }
        public float perimeter()
        {
            P = a + b + c;
            Console.WriteLine("Периметр фигуры: " + P);
            return P;
        }
        public float half_meter()
        {
            p = (a + b + c) / 2;
            return p;
        }
        public float square()
        {
            S = (float)Math.Sqrt(half_meter()*(half_meter()-a)* (half_meter() - b)* (half_meter() - c));
            Console.WriteLine("Площадь фигуры: " + S);
            return S;
        }
    }
    internal class circle
    {
        public float r;
        public float S;
        public float P;
        public void info()
        {
            r = float.Parse(Console.ReadLine());
        }
        public float square()
        {
            S = (float)Math.PI * (float)Math.Pow(r, 2);
            Console.WriteLine("Площадь фигуры: " + S);
            return S;
        }
        public float perimeter()
        {
            P = 2 * (float)Math.PI * r;
            Console.WriteLine("Периметр фигуры: " + P);
            return P;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main()
        {
            while (true)
            {
                int var;
                triangle1 tri = new triangle1();
                circle1 cir = new circle1();
                rectangle1 rec = new rectangle1();
                square1 squ = new square1();
                pyramid pyr = new pyramid();
                Console.WriteLine("1 - квадрат, 2 - прямоугольник, 3 - круг, 4 - тругольник, 5 - пирамида.");
                var = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                if (var == 1)
                {
                    Console.WriteLine("Квадрат");
                    squ = new square1();
                    squ.info();
                    squ.out_info();
                }
                else if (var == 2)
                {
                    Console.WriteLine("Прямоугольник");
                    rec = new rectangle1();
                    rec.info();
                    rec.out_info();
                }
                else if (var == 3)
                {
                    Console.WriteLine("Круг");
                    cir = new circle1();
                    cir.info();
                    cir.out_info();
                }
                else if (var == 4)
                {
                    Console.WriteLine("Треугольник");
                    tri = new triangle1();
                    tri.info();
                    tri.vivod();
                }
                else if (var == 5)
                {
                    Console.WriteLine("Пирамида");
                    pyr = new pyramid();
                    pyr.info();
                    pyr.out_info();
                }
            }
        }
    }
}

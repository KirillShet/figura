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
                int var = 0;
                triangle tri = new triangle();
                circle cir = new circle();
                rectangle rec = new rectangle();
                square squ = new square();
                Console.WriteLine("1 - квадрат, 2 - прямоугольник, 3 - круг, 4 - тругольник.");
                var = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                if (var == 1)
                {
                    Console.WriteLine("Квадрат");
                    squ = new square();
                    squ.info();
                    squ.perimeter();
                    squ.Square();
                }
                else if (var == 2)
                {
                    Console.WriteLine("Прямоугольник");
                    rec = new rectangle();
                    rec.info();
                    rec.perimeter();
                    rec.square();
                }
                else if (var == 3)
                {
                    Console.WriteLine("Круг");
                    cir = new circle();
                    cir.info();
                    cir.perimeter();
                    cir.square();
                }
                else if (var == 4)
                {
                    Console.WriteLine("Треугольник");
                    tri = new triangle();
                    tri.info();
                    tri.prov();
                    if (tri.prov() == false)
                    {
                        Console.WriteLine("Такого треугольника не существует.");
                    }
                    else
                    {
                        tri.half_meter();
                        tri.perimeter();
                        tri.square();
                    }
                }
                else
                {
                    Console.WriteLine("Вы ввели не то число.");
                }
            }
        }
    }
}

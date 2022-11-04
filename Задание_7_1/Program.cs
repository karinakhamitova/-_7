using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_7_1
{
    internal class Program
    {
        static double GetTriangleSquare(double a, double b, double c)
        {
            double p = (a + b + c) / 2;
            return (Math.Sqrt(p * (p - a) * (p - b) * (p - c)));
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите стороны треугольника 1");
            double x1 = Convert.ToDouble(Console.ReadLine());
            double y1 = Convert.ToDouble(Console.ReadLine());
            double z1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите стороны треугольника 2");
            double x2 = Convert.ToDouble(Console.ReadLine());
            double y2 = Convert.ToDouble(Console.ReadLine());
            double z2 = Convert.ToDouble(Console.ReadLine());
            if (GetTriangleSquare(x1, y1, z1) > GetTriangleSquare(x2, y2, z2))
            {
                Console.WriteLine("Площадь треугольника 1 больше");
            }
            else if (GetTriangleSquare(x1, y1, z1) < GetTriangleSquare(x2, y2, z2))
            {
                Console.WriteLine("Площадь треугольника 2 больше");
            }
            else 
            {
                Console.WriteLine("Площадь треугольников равны");
            }
            Console.ReadKey();
        }
    }
}

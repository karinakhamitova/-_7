using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_7_2
{
    internal class Program
    {
        static void GetCubeParam(double a, out double S, out double V)
        {
            S = 6 * a * a;
            V = a * a * a;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите сторону куба");
            double a = Convert.ToDouble(Console.ReadLine());
            double S, V;
            GetCubeParam(a, out S, out V);
            Console.WriteLine("S = {0:.00}, V = {1:.00}",S,V);
            Console.ReadKey();  
        }
    }
}

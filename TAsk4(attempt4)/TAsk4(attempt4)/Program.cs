using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAsk4_attempt4_
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = Koren(2, 3);
            double b = Koren(7, 8);
            double c = Koren(1, 4);
            double result = a + b + c;
            Console.WriteLine($"результат равен:{result:F3}");
            Console.ReadKey();
        }
        static double Koren(double x, double t)
        {

            return (Math.Sqrt(x + Math.Tan(t))) / (x * x + t * t);



        }
    }
}

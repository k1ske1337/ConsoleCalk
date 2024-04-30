using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Class10
    {
        public class SquareRoot
        {
            public static double Perform(double number)
            {
                if (number < 0)
                {
                    Console.WriteLine("Невозможно вычислить квадратный корень из отрицательного числа!");
                    return double.NaN;
                }
                else
                {
                    return Math.Sqrt(number);
                }
            }
        }
    }
}

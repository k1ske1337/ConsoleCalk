using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Class4
    {
        public class Division
        {
            public static double Perform(double a, double b)
            {
                if (b == 0)
                {
                    Console.WriteLine("Нельзя делить на ноль!");
                    return double.NaN;
                }
                else
                {
                    return a / b;
                }
            }
        }
    }
  
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    public class _07_Calc
    {
        public static void calc()
        {
            Console.Write("Enter num1: ");
            double num1=Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter num2 : ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(num1+num2);
        }
    }
}

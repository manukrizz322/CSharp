using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    public class _12_Function_Calculator
    {
        public static void calcu()
        {
            Console.Write("Enter num1 : ");
            double num1=Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Operator :");
            string op=Console.ReadLine();

            Console.Write("Enter num2 :");
            double num2=Convert.ToDouble(Console.ReadLine());

            if(op=="+")
                Console.WriteLine(num1 + num2);
            else if(op=="-")
                Console.WriteLine(num1 - num2);
            else if (op=="*")
                Console.WriteLine(num1 * num2);
            else if (op == "/")
                Console.WriteLine(num1 / num2);
            else
                Console.WriteLine("Invalid Operator");
        }


    }
}

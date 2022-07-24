using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    public class _05_Math
    {
        public static void math()
        {
            Console.WriteLine(2*3);
            Console.WriteLine(10%3);
            Console.WriteLine(1+2*3);
            Console.WriteLine(10/3.0);

            int num = 10;
            num += 100;
            Console.WriteLine(num);

            num++;
            Console.WriteLine(num);

            Console.WriteLine(Math.Pow(2,3));
            Console.WriteLine(Math.Sqrt(144));
            Console.WriteLine(Math.Round(2.7));

            Console.ReadLine();

        }
         

    }
}

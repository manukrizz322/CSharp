using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    public class _09_Arrays
    {
        public static void array()
        {
            int[] luckyNumbers = {4,8,15,16,23,42};
            luckyNumbers[0] = 90;
            Console.WriteLine(luckyNumbers[0]);
            Console.WriteLine(luckyNumbers[1]);
            Console.WriteLine(luckyNumbers.Length);
            Console.ReadLine();
        }
    }
}

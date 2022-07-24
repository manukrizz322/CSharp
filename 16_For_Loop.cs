using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    public class _16_For_Loop
    {
        public static void for_1()
        {
            for (int i = 0; i < 5; i++)
                Console.WriteLine(i);

            int[] luckyNums = {3,2,5,6,7,8,4,6 };
            foreach (int luckyNum in luckyNums)
                Console.WriteLine(luckyNum);

        }
    }
}

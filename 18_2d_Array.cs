using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    public class _18_2d_Array
    {
        public static void _array2d()
        {
            int[][] numberGrid =
            {
               new int[] {1,2},
               new int[] {3,4}

            };
            numberGrid[0][1]= 99;
            Console.WriteLine(numberGrid[0][0]);
            Console.WriteLine(numberGrid[0][1]);

            for (int i = 0; i < numberGrid.Length; i++)
                for (int j = 0; j < numberGrid[i].Length; j++)
                    Console.WriteLine(numberGrid[i][j]);
        }
    }
}

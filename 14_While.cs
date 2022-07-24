using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    public class _14_While
    {
        public static void wile()
        {
            int index = 1;
            while (index <= 5)
            {
                Console.WriteLine(index);
                index++;
            }


        }
        public static void dowile()
        {
            int index = 1;
            do
            {
                Console.WriteLine(index);
                index++;
            } while (index <= 5);

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    public class _13_Switch
    {
        public static void swtch()
        {
            char myGrade = 'A';
            switch (myGrade)
            {
                case 'A':
                    Console.WriteLine("You Pass");
                    break;
                case 'F':
                    Console.WriteLine("You fail");
                    break;
                default:
                    Console.WriteLine("Invalid grade");
                    break;
            }
        }
    }
}

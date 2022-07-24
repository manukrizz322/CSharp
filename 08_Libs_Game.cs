using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    public class _08_Libs_Game
    {
        public static void game()
        {
            Console.WriteLine("Enter color : ");
            string color =Console.ReadLine();

            Console.Write("Enter plural noun : ");
            string pluralNoun=Console.ReadLine();

            Console.Write("Enter celebrity : ");
            string celebrity=Console.ReadLine();

            Console.WriteLine($"Roses ara {color}");
            Console.WriteLine($"{pluralNoun} are blue" );
            Console.WriteLine($"I love {celebrity}");
        }
    }
}

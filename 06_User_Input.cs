using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    public class _06_User_Input
    {
        public static void user()
        {
            Console.Write("Enter UserName : ");
            String username = Console.ReadLine();
            Console.WriteLine($"Hello {username}");
            Console.ReadLine();
            
        }
    }
}

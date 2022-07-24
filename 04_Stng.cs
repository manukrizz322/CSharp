using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    public  class Stng
    {
        public static void stg()
        {
            string greeting = "Hello";
            Console.WriteLine(greeting[0]);
            Console.WriteLine(greeting.Length);
            Console.WriteLine(greeting.IndexOf("llo"));    
            Console.WriteLine(greeting.IndexOf("z"));
            Console.WriteLine(greeting.Substring(2));
            Console.WriteLine(greeting.Substring(1,3));

        }

    }
}

using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    public class _25_ArrayList
    {
        public static void list()
        {

            ArrayList friends = new ArrayList();
            friends.Add("Oscar");
            friends.Add("Angela");
            friends.Add("Kevin");

            //friends.Remove("Oscar");
            Console.WriteLine(friends[0]);
            Console.WriteLine(friends[1]);
            Console.WriteLine(friends.Contains("Oscar"));
            Console.WriteLine(friends.Count);


        }
    }
}

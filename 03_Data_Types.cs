using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    public class Data_Types
    {
        public static void data()
        {
            String name = "Mike";//strings are objects not primitive
            char testGrade = 'A';//single 16-bit Unicode character

            //short,int,Long can be pre-pended with 'u' for unsigned
            byte age0 = 0;//8-bit unsigned integer
            short age1 = 10;//16-bit signed integer.
            int age2 = 20;//32-bit signed integer
            long age3 = 30;//64-bit signed integer

           float gpa0 = 2.5F;//32-bit floating point
            double gpa1 = 3.5;//64-bit double-precision floating point
            decimal gpa2 = 4.5M;//128-bit precise decimal

            bool isTall;//1 bit -->true/false
            isTall = true;

            name = "John";

            Console.WriteLine("Your name is "+name);
            Console.WriteLine($"Your name is {name}");


        }
    }
}

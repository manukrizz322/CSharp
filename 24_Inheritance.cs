using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    public class Chef
    {
        public void MakeChicken()
        {
            Console.WriteLine("The chef makes chicken");
        }
        public void MakeSalad()
        {
            Console.WriteLine("The chef makes salad");
        }
        public virtual void MakeSpecialDish()
        {
            Console.WriteLine("The chef makes a special dish");

        }
    }
    public class ItalianChef :Chef
    {
        public void MakesPasta()
        {
            Console.WriteLine("The Chef make's past");
        }
        public override void MakeSpecialDish()
        {
           Console.WriteLine("The chef makes chicken parm");
        }
    }
}

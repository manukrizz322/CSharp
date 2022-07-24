using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    abstract class Vehicle
    {
        public abstract void move();
        public void getDescription()
        {
            Console.WriteLine("Vehicles are used for transportation");
        }

    }
    class Bicycle : Vehicle
    {
        public override void move()
        {
            Console.WriteLine("The bicycle pedals forward");
        }
    }
    class Plane : Vehicle
    {
        public override void move()
        {
            Console.WriteLine("The plane flys through the sky");
        }
    }
}

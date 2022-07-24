using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    public interface Animal
    {
        void Speak();
        void Eat();
    }
    public class Dog : Animal
    {
        public void Speak()
        {
            Console.WriteLine("Woof Woof");
        }
        public void Eat()
        {
            Console.WriteLine("Eat");
        }
    }
    public class Cat : Animal
    {
        public void Speak()
        {
            Console.WriteLine("Meow Meow");
        }
        public void Eat()
        {
            Console.WriteLine("Eat");
        }
        Animal[] animals = {
                            new Dog(),
                                         new Cat() };
        /*                   
        foreach(Animal animal in animals){
        animal.speak();*/
    }
}

    

    

     


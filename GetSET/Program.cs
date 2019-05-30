using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetSET
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog spooty = new Dog();
            spooty.name = "spooty";
            spooty.age = 2;
            spooty.happiness = 10;
            spooty.spotCount = 25;
            spooty.PrintBase();
            spooty.Bark();
            Console.WriteLine("New happiness: {0}", spooty.happiness);

            Console.WriteLine();

            Cat Carmen = new Cat();
            Carmen.name = "Carmen";
            Carmen.age = 24;
            Carmen.happiness = 1;
            Carmen.cuteness = 99;
            Carmen.PrintBase();
            Carmen.Meow();

        }
    }

    class Animal
    {
        public string name;
        public int age;
        public int happiness;

        public void PrintBase()
        {
            Console.WriteLine("Name: {0}", name);
            Console.WriteLine("Age: {0}", age);
            Console.WriteLine("Happiness: {0}", happiness);
        }
    }
    
    class Dog : Animal
    {
        public int spotCount;
        public void Bark()
        {
            Console.WriteLine("WOOF");
            base.happiness += 1;
        }
    }
    class Cat : Animal
    {
        public int cuteness;
        public void Meow()
        {
            Console.WriteLine("MEOWWWWWWWWWWW");
        }
    }

}

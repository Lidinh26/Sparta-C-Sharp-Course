using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labs_classes_tester
{
    class Program
    {
        static void Main(string[] args)
        {
            var Li = new parent("Li", 12);
            Console.WriteLine("Your name is: {0}", Li.name);
            Console.WriteLine("Your age is: {0}", Li.age);
            Li.SayHi();
        }

        class parent
        {
            public string name;
            public int age { get; set; }

            public parent(string name, int age)
            {
                this.name = name;
                this.age = age;
            }

            public void SayHi()
            {
                Console.WriteLine("Hello idiot!");
            }
        }

        abstract class parent2
        {
            abstract public void NeedToPoo();
            public void EatPoo()
            {
                Console.WriteLine("Yum!");
            }
        }

        class child : parent2
        {
            public override void NeedToPoo()
            {
                Console.WriteLine("Not sure if it tastes nice???");
            }
        }

    }
}

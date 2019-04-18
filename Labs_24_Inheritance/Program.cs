using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labs_24_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {

            var p01 = new Parent();
            p01.Name = "Father";
            var c01 = new Child();
            c01.Name = "Child";
            // give age
            c01.Age = 12;
            //make grow in loop : 10 times
            c01.Grow();
            Console.WriteLine($"You're one year older {c01.Age} child");
            c01.Grow();
            Console.WriteLine($"You're one year older {c01.Age} child");


            Console.WriteLine(c01.GrowReturnAge()); //increase age, print new age
            Console.WriteLine(c01.GrowReturnAge());
            Console.WriteLine(c01.GrowReturnAge());
            var newAge = c01.GrowReturnAge();
            newAge = c01.GrowReturnAge();


        }

    }

    class Parent
    {

        public string Name;
        public int Age;
        //age
        public void Grow()
        {
            Age++;

        }

        public int GrowReturnAge()
        {

            Age++;
            return Age;

        }

    }

    class Child : Parent {}
}

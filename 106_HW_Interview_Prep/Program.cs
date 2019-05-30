using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_HW_106_Interview_Prep
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\n----------------------------------INHERITANCE-------------------------------------\n\n");

            Dog Woofy = new Dog();
            Woofy.name = "Woofy";
            Woofy.age = 5;
            Woofy.height = 50;
            Woofy.weight = 60;
            Woofy.Print();

            Console.WriteLine("\n\n----------------------------------SEALED CLASS-------------------------------------\n\n");

            SealedClass TEST = new SealedClass();
            int total = TEST.add(10, 5);
            Console.WriteLine($"I am using my sealed class with an ADD method : {total}");

            Console.WriteLine("\n\n-------------------------------ABSTRACT CLASS------------------------------------\n\n");

            Child Li = new Child();
            Li.AbstractTest();

            GrandChild Jas = new GrandChild();
            Jas.AbstractTest();

            Console.WriteLine("\n\n---------------------------------OVERLOAD--------------------------------------\n\n");

            multiply(5, 5);

            multiply(5, 5, 5);

        }

        static void multiply(int x, int y)
        {
           int results = x* y;
            Console.WriteLine(results);
        }

        static void multiply(int x, int y, int z)
        {
            int results = x * y * z;
            Console.WriteLine(results);
        }
    }

    class Animal
    {
        public string name;
        public int age { get; set; }
        public int height;
        public double weight;
        virtual public void Print()
        {
            Console.WriteLine($"My name is {name} and I'm {age} years old. I weigh {weight} KG and I'm {height} CM tall");
        }
    }

    class Dog : Animal
    {
        override public void Print()
        {
            Console.WriteLine($"My name is {name} and I'm {age} years old. I weigh {weight} KG and I'm {height} cm tall");
        }
    }

    sealed class SealedClass //Doesnt allow inheritance feature 
    {
        public int add(int x, int y)
        {
            return x + y;
        }
    }

    abstract class Parent
    {
        public abstract void AbstractTest();
    }

    class Child : Parent
    {
        public override void AbstractTest()
        {
            Console.WriteLine("Hello im the child");
        }
    } 

    class GrandChild : Child
    {
        public override void AbstractTest()
        {
            Console.WriteLine("Hello im the daughter");
        }
    }


    public class ASCII
    {
        //Goal is return ASCII number of the character number sent in
        //Input a string e.g "Hello" and an index e.g 3
        //return ASCII number of letter 'l'

        public int ASCII_Return_Index_Of_String(string input, int index)
        {

            // find character of the index
            char character = input[index];
            //Convert the character into a char

            return -1;
        }
    }


    
}

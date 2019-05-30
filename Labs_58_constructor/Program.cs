using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labs_58_constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            var d = new Dog();
            var d1 = new Dog(10);
            var s = new Spaniel(10);
            var s1 = new Spaniel(10); // INSTRUCTOR IS NOT INHERITED 
            d.grow();
            s.grow(); // METHOD IS INHERITED

        }
    }

    public class Dog
    {
        public int age { get; set; }

        public Dog(int age)
        {
            this.age = age;
        }

        public Dog()
        {

        }
        public void grow() { age++; } //This is inherited as its not a constructor 

    }
    class Spaniel : Dog
    {
        public Spaniel(int age)
        {
            this.age = age;
        }
    }

    public static class EngineeringConstants
    {
        public static double Constant01 = 2.45793;
    }

}

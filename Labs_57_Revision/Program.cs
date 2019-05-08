using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labs_57_Revision
{
    class Program
    {
        static void Main(string[] args)
        {
            var D = new Dog(100); // d is 'instance'
            var s = new Spaniel();
            s.Height = 100;

            var p = new Parent();
            var c = new Child2();

            c.HaveParty();

            p.HaveParty();
        }
    }

    class Dog
    {
        public int Height { get; set; }
        internal int Length { get; set; }
        protected int Weight { get; set; }
        private int _age { get; set; }

        public Dog() { } // default constructor
        public Dog(int Height) // regular constructor
        {
            this.Height = Height;
        }
    }

    class Spaniel : Dog
    {
        public Spaniel()
        {
            this.Height = Height;
            
        }
    }

    class Parent
    {
        public virtual void HaveParty() { Console.WriteLine("Boring Party"); }
    }

    class Child1 : Parent
    {
        public override void HaveParty() { Console.WriteLine("Boring Party"); }
    }
    class Child2 : Parent
    {
        public override void HaveParty() { Console.WriteLine("HELLOWEELFWV Party"); }
    }
    class Child3 : Parent
    {
        public override void HaveParty() { Console.WriteLine("Boring Party"); }
    }
}
